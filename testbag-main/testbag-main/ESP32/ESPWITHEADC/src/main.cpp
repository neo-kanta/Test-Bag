#include <Arduino.h>
#include <SPI.h>
#include <Adafruit_ADS1X15.h>
#include <WiFi.h>
#include <WiFiUdp.h>
#include <PZEM004Tv30.h>
#include <ESPmDNS.h>
#include <WebServer.h>

namespace {
constexpr uint8_t kLedPin = 2;
constexpr uint8_t kChipSelectPin = 15;

// ADS1115 channels are 0..3.
constexpr uint8_t kVoltageAdcChannel = 0;
constexpr uint8_t kCurrentAdcChannel = 1;

constexpr uint16_t kUdpPort = 8080;
constexpr uint16_t kHttpPort = 80;
constexpr uint32_t kStartDelayMs = 500;
constexpr uint32_t kConnectionCheckIntervalMs = 10000;
constexpr uint32_t kLoopDelayMs = 1000;
constexpr uint8_t kMaxRetries = 5;

constexpr float kAdsLsbVolts = 0.0001875f;

Adafruit_ADS1115 gAds;
WebServer gServer(kHttpPort);
WiFiUDP gUdp;

#if defined(ESP32)
PZEM004Tv30 gPzem(Serial2, 16, 17);
#else
PZEM004Tv30 gPzem(Serial2);
#endif

IPAddress gComputerIp;
unsigned long gLastConnectionCheckMs = 0;
int gSequenceNumber = 0;

constexpr size_t kBufferSize = 100;
char gBufferData[kBufferSize] = "ESP32";

void connectToWiFi(const char* ssid, const char* password) {
  WiFi.begin(ssid, password);

  while (WiFi.status() != WL_CONNECTED) {
    digitalWrite(kLedPin, HIGH);
    delay(kStartDelayMs);
    Serial.println(".");
    digitalWrite(kLedPin, LOW);
  }

  Serial.print("Connected to: ");
  Serial.println(WiFi.SSID());
  Serial.print("IP Address: ");
  Serial.println(WiFi.localIP());
  gUdp.begin(kUdpPort);
}

void initMdns() {
  if (!MDNS.begin("ESP32")) {
    Serial.println("Error starting mDNS");
    return;
  }

  Serial.println("mDNS started");
  MDNS.addService("udp", "tcp", kUdpPort);
}

void handleWifiConfig() {
  const String ssid = gServer.arg("ssid");
  const String password = gServer.arg("password");

  gServer.send(200, "text/plain", "Wi-Fi credentials received.");
  Serial.println("Received Wi-Fi credentials:");
  Serial.print("SSID: ");
  Serial.println(ssid);
  Serial.print("Password: ");
  Serial.println(password);

  connectToWiFi(ssid.c_str(), password.c_str());
}

void setupHttpServer() {
  gServer.on("/wifiConfig", handleWifiConfig);
  gServer.begin();
}

void checkConnection() {
  const unsigned long now = millis();
  if (now - gLastConnectionCheckMs <= kConnectionCheckIntervalMs) {
    return;
  }

  gLastConnectionCheckMs = now;
  if (WiFi.status() == WL_CONNECTED) {
    return;
  }

  Serial.println("Disconnected. Attempting to reconnect...");
  WiFi.beginSmartConfig();
}

float sanitizePzemReading(float value, const char* errMessage) {
  if (isnan(value)) {
    Serial.println(errMessage);
    return 0.0f;
  }
  return value;
}

void buildMeasurementPacket(char* buffer, size_t size) {
  const int16_t voltageRaw = gAds.readADC_SingleEnded(kVoltageAdcChannel);
  const int16_t currentRaw = gAds.readADC_SingleEnded(kCurrentAdcChannel);

  const float voltageVolts = static_cast<float>(voltageRaw) * kAdsLsbVolts;
  const float currentVolts = static_cast<float>(currentRaw) * kAdsLsbVolts;

  const float voltagePzem = sanitizePzemReading(gPzem.voltage(), "Cannot read voltage from PZEM");
  const float currentPzem = sanitizePzemReading(gPzem.current(), "Cannot read current from PZEM");

  snprintf(buffer,
           size,
           "S%d|DC%dA|DC%dV|AC%.2fA|AC%.2fV",
           gSequenceNumber,
           currentRaw,
           voltageRaw,
           currentPzem,
           voltagePzem);

  Serial.printf("ADC volts: V=%.3fV I=%.3fV\n", voltageVolts, currentVolts);
}

bool waitForAck(int expectedSequence) {
  int packetSize = gUdp.parsePacket();
  if (packetSize <= 0) {
    return false;
  }

  int len = gUdp.read(gBufferData, sizeof(gBufferData) - 1);
  if (len <= 0) {
    return false;
  }

  gBufferData[len] = '\0';
  Serial.print("Received ACK from computer: ");
  Serial.println(gBufferData);

  if (strncmp(gBufferData, "ACK", 3) != 0) {
    return false;
  }

  const int receivedSequence = atoi(gBufferData + 3);
  return receivedSequence == expectedSequence;
}

bool sendPacketWithRetry(const char* payload) {
  for (uint8_t retry = 0; retry < kMaxRetries; ++retry) {
    digitalWrite(kLedPin, HIGH);
    gUdp.beginPacket(gComputerIp, kUdpPort);
    gUdp.print(payload);
    gUdp.endPacket();
    digitalWrite(kLedPin, LOW);

    if (waitForAck(gSequenceNumber)) {
      return true;
    }

    delay(kLoopDelayMs);
  }

  return false;
}
}  // namespace

void setup() {
  Serial.begin(115200);
  SPI.begin();
  WiFi.beginSmartConfig();

  gAds.begin(0x48);
  gAds.setGain(GAIN_TWO);
  gAds.setDataRate(860);

  pinMode(kChipSelectPin, OUTPUT);
  digitalWrite(kChipSelectPin, HIGH);

  WiFi.mode(WIFI_STA);
  initMdns();
  setupHttpServer();

  pinMode(kLedPin, OUTPUT);
}

void loop() {
  gServer.handleClient();
  checkConnection();

  buildMeasurementPacket(gBufferData, sizeof(gBufferData));
  Serial.println(gBufferData);

  const bool delivered = sendPacketWithRetry(gBufferData);
  if (delivered) {
    Serial.println("Packet successfully delivered.");
  } else {
    Serial.println("Error: Packet not acknowledged.");
  }

  ++gSequenceNumber;
  memset(gBufferData, 0, sizeof(gBufferData));
  delay(kLoopDelayMs);
}
