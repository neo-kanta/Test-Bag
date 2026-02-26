#include <Arduino.h>
#include <WiFi.h>
#include <WiFiUdp.h>
#include <PZEM004Tv30.h>
#include <ESPAsyncWebServer.h>
#include <AsyncTCP.h>
#include <ESPmDNS.h>

namespace {
constexpr uint8_t kLedPin = 2;
constexpr uint8_t kRelayPin = 25;
constexpr uint8_t kVoltageSensorPin = 32;
constexpr uint8_t kCurrentSensorPin = 35;
constexpr uint8_t kPzemRxPin = 16;
constexpr uint8_t kPzemTxPin = 17;

constexpr uint16_t kUdpPort = 8080;
constexpr uint16_t kHttpPort = 80;
constexpr uint32_t kSendDelayMs = 10;
constexpr uint32_t kMdnsCheckIntervalMs = 10000;

constexpr const char* kHotspotSsid = "SunnySSID";
constexpr const char* kHotspotPassword = "admin123";
constexpr const char* kMdnsHost = "esp32";

constexpr size_t kBufferSize = 100;

unsigned long gLastMdnsCheckMs = 0;
IPAddress gUdpTargetIp;
char gBufferData[kBufferSize] = "ESP32";

AsyncWebServer gServer(kHttpPort);
WiFiUDP gUdp;

#if defined(ESP32)
PZEM004Tv30 gPzem(Serial2, kPzemRxPin, kPzemTxPin);
#else
PZEM004Tv30 gPzem(Serial2);
#endif

TaskHandle_t gUdpTask = nullptr;
TaskHandle_t gMdnsTask = nullptr;

void connectToWiFi(const char* ssid, const char* password) {
  WiFi.begin(ssid, password);

  while (WiFi.status() != WL_CONNECTED) {
    digitalWrite(kLedPin, HIGH);
    Serial.println(".");
    digitalWrite(kLedPin, LOW);
    delay(300);
  }

  Serial.print("Connected to: ");
  Serial.println(WiFi.SSID());
  Serial.print("IP Address: ");
  Serial.println(WiFi.localIP());
  gUdp.begin(kUdpPort);
}

String getConnectionStatus() {
  return WiFi.status() == WL_CONNECTED ? "connected" : "disconnected";
}

String readPinStatus() {
  const String ledStatus = digitalRead(kLedPin) ? "1" : "0";
  const String relayStatus = digitalRead(kRelayPin) ? "1" : "0";
  return "LED:" + ledStatus + ",RELAY:" + relayStatus;
}

String readAllStatus() {
  const String wifiStatus = WiFi.status() == WL_CONNECTED ? "1" : "0";
  const String ledStatus = digitalRead(kLedPin) ? "1" : "0";
  const String relayStatus = digitalRead(kRelayPin) ? "1" : "0";
  return "CONNECTION:" + wifiStatus + ",LED:" + ledStatus + ",RELAY:" + relayStatus;
}

void handleWifiConfig(AsyncWebServerRequest* request) {
  const String ssid = request->arg("ssid");
  const String password = request->arg("password");

  request->send(200, "text/plain", "Wi-Fi credentials received.");
  Serial.println("Received Wi-Fi credentials:");
  Serial.print("SSID: ");
  Serial.println(ssid);
  Serial.print("Password: ");
  Serial.println(password);

  // Keep legacy behavior: connect to hard-coded hotspot.
  connectToWiFi(kHotspotSsid, kHotspotPassword);
}

void handleCheckWifiConnection(AsyncWebServerRequest* request) {
  request->send(200, "text/plain", getConnectionStatus());
}

void handleChangeUdpTargetIp(AsyncWebServerRequest* request) {
  const String ipAddress = request->arg("ip");
  IPAddress parsedIp;

  if (!parsedIp.fromString(ipAddress)) {
    request->send(400, "text/plain", "Invalid IP address format.");
    Serial.println("Invalid IP address format.");
    return;
  }

  gUdpTargetIp = parsedIp;
  request->send(200, "text/plain", "IP address changed to: " + ipAddress);
  Serial.println("UDP target IP changed to: " + ipAddress);
}

void handlePinStatus(AsyncWebServerRequest* request) {
  request->send(200, "text/plain", readPinStatus());
}

void handleToggleLed(AsyncWebServerRequest* request) {
  digitalWrite(kLedPin, !digitalRead(kLedPin));
  request->send(200, "text/plain", digitalRead(kLedPin) ? "ON" : "OFF");
}

void handleToggleRelay(AsyncWebServerRequest* request) {
  digitalWrite(kRelayPin, !digitalRead(kRelayPin));
  request->send(200, "text/plain", digitalRead(kRelayPin) ? "ON" : "OFF");
}

void handleCheckAllStatus(AsyncWebServerRequest* request) {
  request->send(200, "text/plain", readAllStatus());
}

void setupHttpServer() {
  gServer.on("/setwifi", HTTP_POST, handleWifiConfig);
  gServer.on("/checkwifi", HTTP_GET, handleCheckWifiConnection);
  gServer.on("/toggleled", HTTP_GET, handleToggleLed);
  gServer.on("/togglerelay", HTTP_GET, handleToggleRelay);
  gServer.on("/setudptarget", HTTP_POST, handleChangeUdpTargetIp);
  gServer.on("/pinstatus", HTTP_GET, handlePinStatus);
  gServer.on("/checkallstatus", HTTP_GET, handleCheckAllStatus);
  gServer.begin();
}

void setupPins() {
  pinMode(kLedPin, OUTPUT);
  digitalWrite(kLedPin, LOW);

  pinMode(kRelayPin, OUTPUT);
  digitalWrite(kRelayPin, LOW);

  pinMode(kVoltageSensorPin, INPUT);
  pinMode(kCurrentSensorPin, INPUT);
}

void updateMdns() {
  if (WiFi.status() != WL_CONNECTED) {
    MDNS.end();
    return;
  }

  if (!MDNS.begin(kMdnsHost)) {
    Serial.println("Error setting up mDNS responder!");
    return;
  }

  Serial.println("mDNS responder started");
}

void readAndFormatData(char* buffer, size_t bufferSize) {
  const int currentReading = analogRead(kCurrentSensorPin);
  const int voltageReading = analogRead(kVoltageSensorPin);

  float voltagePzem = gPzem.voltage();
  float currentPzem = gPzem.current();

  if (isnan(voltagePzem)) {
    voltagePzem = 0.0f;
  }
  if (isnan(currentPzem)) {
    currentPzem = 0.0f;
  }

  snprintf(buffer,
           bufferSize,
           "DC%dA|DC%dV|AC%.2fA|AC%.2fV",
           currentReading,
           voltageReading,
           currentPzem,
           voltagePzem);
}

void udpSendDataTask(void* /*parameter*/) {
  for (;;) {
    digitalWrite(kLedPin, HIGH);

    readAndFormatData(gBufferData, sizeof(gBufferData));
    gUdp.beginPacket(gUdpTargetIp, kUdpPort);
    gUdp.print(gBufferData);
    gUdp.endPacket();
    Serial.println(gBufferData);

    memset(gBufferData, 0, sizeof(gBufferData));
    digitalWrite(kLedPin, LOW);
    vTaskDelay(pdMS_TO_TICKS(kSendDelayMs));
  }
}

void mdnsTaskFunction(void* /*parameter*/) {
  for (;;) {
    const unsigned long now = millis();
    if (now - gLastMdnsCheckMs > kMdnsCheckIntervalMs) {
      updateMdns();
      gLastMdnsCheckMs = now;
    }

    vTaskDelay(pdMS_TO_TICKS(10));
  }
}
}  // namespace

void setup() {
  Serial.begin(115200);
  Serial2.begin(9600, SERIAL_8N1, kPzemRxPin, kPzemTxPin);
  analogReadResolution(12);

  setupPins();
  connectToWiFi(kHotspotSsid, kHotspotPassword);
  setupHttpServer();

  xTaskCreate(udpSendDataTask, "udpSendDataTask", 10000, nullptr, 2, &gUdpTask);
  xTaskCreate(mdnsTaskFunction, "mdnsTaskFunction", 10000, nullptr, 1, &gMdnsTask);
}

void loop() {}
