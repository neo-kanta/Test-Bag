#include <Arduino.h>
#include <WiFi.h>
#include <WiFiUdp.h>
#include <string.h>
#include <HardwareSerial.h>
#include <PZEM004Tv30.h>
#include <ESPAsyncWebServer.h>
#include <AsyncTCP.h>
#include <ESPmDNS.h>

#define LED_PIN 2
#define RELAY_PIN 25
#define VOLTAGE_SENSOR_PIN 32
#define CURRENT_SENSOR_PIN 35
#define PZEM_RX_PIN 16
#define PZEM_TX_PIN 17
#define PZEM_SERIAL Serial2

#if defined(ESP32)    
PZEM004Tv30 pzem(PZEM_SERIAL, PZEM_RX_PIN, PZEM_TX_PIN);
#else
PZEM004Tv30 pzem(Serial2);
#endif

const int UDP_PORT = 8080;
IPAddress udpTargetIP;

const int HTTP_PORT = 80;
const int sendDelayMs = 10; // Adjust this value to change the sending rate
const char * HOTSPOT_SSID = "SunnySSID"; // => HOTSPOT
const char * HOTSPOT_PASSWORD = "admin123"; // => HOTSPOT
const char * SERVICE_TYPE = "_http";
const int READING_SPEED = 50;
const int START_DELAY_MS = 100;

unsigned long LAST_CONNECTION_CHECK = 0 ; 
unsigned long CONNECTION_CHECK_INTERVAL_MS = 10000;

AsyncWebServer server(HTTP_PORT);
WiFiUDP udp;
#define nBuffer 100
char bufferData[nBuffer] = "ESP32";

char voltageStringPzem[10];
char currentStringPzem[10];   


void connectToWiFi(const char *ssid, const char *password) {
    WiFi.begin(ssid, password);
    while (WiFi.status() != WL_CONNECTED) 
    {
        digitalWrite(LED_PIN, HIGH);
        Serial.println(".\n");
        digitalWrite(LED_PIN, LOW);
    }
    Serial.print("Connected to : ");
    Serial.println(WiFi.SSID());
    Serial.println("IP Address : ");
    Serial.println(WiFi.localIP());
    udp.begin(UDP_PORT);
}

void handleWifiConfig(AsyncWebServerRequest *request) {
    String ssid = request->arg("ssid");
    String password = request->arg("password");

    request->send(200, "text/plain", "Wi-Fi credentials received.");
    Serial.println("Received Wi-Fi credentials:");
    Serial.print("SSID: ");
    Serial.println(ssid);
    Serial.print("Password: ");
    Serial.println(password);

    connectToWiFi(HOTSPOT_SSID, HOTSPOT_PASSWORD);
}

void handleCheckWifiConnection(AsyncWebServerRequest *request) {
    if (WiFi.status() == WL_CONNECTED) {
        request->send(200, "text/plain", "connected");
    } else {
        request->send(200, "text/plain", "disconnected");
    }
}

void handleChangeIP(AsyncWebServerRequest *request) {
    String ipAddress = request->arg("ip");
    Serial.print("IP:" + String(ipAddress));

    IPAddress ip;
    if (ip.fromString(ipAddress)) {
        udpTargetIP = ip;
        //WiFi.config(ip, WiFi.gatewayIP(), WiFi.subnetMask());
        request->send(200, "text/plain", "IP address changed to: " + ipAddress);
        Serial.println("###################### IP address changed to: " + ipAddress);
    } else {
        request->send(400, "text/plain", "Invalid IP address format.");
        Serial.println("Invalid IP address format.");
    }
}
void handlePinStatus(AsyncWebServerRequest *request) {
    String ledStatus = digitalRead(LED_PIN) ? "1" : "0";
    String relayStatus = digitalRead(RELAY_PIN) ? "1" : "0";

    String pinStatus = "LED:" + ledStatus + ",RELAY:" + relayStatus;
    request->send(200, "text/plain", pinStatus);
}

void handleToggleLed(AsyncWebServerRequest *request) {
    digitalWrite(LED_PIN, !digitalRead(LED_PIN));
    String ledState = digitalRead(LED_PIN) ? "ON" : "OFF";
    request->send(200, "text/plain", ledState);
}

void handleToggleRelay(AsyncWebServerRequest *request) {
    digitalWrite(RELAY_PIN, !digitalRead(RELAY_PIN));
    String relayState = digitalRead(RELAY_PIN) ? "ON" : "OFF";
    request->send(200, "text/plain", relayState);
}
void checkALlStatus(AsyncWebServerRequest *request){
    String wifiStatus ;
    if (WiFi.status() == WL_CONNECTED) {
        wifiStatus = "1";
    } else {
        wifiStatus = "0";
    }
    String ledStatus = digitalRead(LED_PIN) ? "1" : "0";
    String relayStatus = digitalRead(RELAY_PIN) ? "1" : "0";
    String entireStatus = "CONNECTION:" + wifiStatus + ",LED:" + ledStatus + ",RELAY:" + relayStatus;
    request->send(200, "text/plain", entireStatus);
}
void setupHttpServer() {
    server.on("/setwifi", HTTP_POST, [](AsyncWebServerRequest *request) { handleWifiConfig(request); });
    server.on("/checkwifi", HTTP_GET, [](AsyncWebServerRequest *request) { handleCheckWifiConnection(request); });
    server.on("/toggleled", HTTP_GET, [](AsyncWebServerRequest *request) { handleToggleLed(request); });
    server.on("/togglerelay", HTTP_GET, [](AsyncWebServerRequest *request) { handleToggleRelay(request); });
    server.on("/setudptarget", HTTP_POST, [](AsyncWebServerRequest *request) { handleChangeIP(request); });
    server.on("/pinstatus", HTTP_GET, [](AsyncWebServerRequest *request) { handlePinStatus(request); });
    server.on("/checkallstatus",HTTP_GET ,[](AsyncWebServerRequest *request){ checkALlStatus(request); });
    server.begin();
}

void setupPin() {
    pinMode(LED_PIN, OUTPUT);
    digitalWrite(LED_PIN, LOW);
    pinMode(RELAY_PIN,OUTPUT);
    digitalWrite(RELAY_PIN,LOW);
    pinMode(VOLTAGE_SENSOR_PIN,INPUT);
    pinMode(CURRENT_SENSOR_PIN,INPUT);
}



void updateMDNS() {
    if (WiFi.status() == WL_CONNECTED) {
        if (!MDNS.begin("esp32")) {
            Serial.println("Error setting up mDNS responder!");
        } else {
            Serial.println("mDNS responder started");
        }
    } else {
        MDNS.end();
    }
}
void dtostrf_fast(float number, uint8_t fracDigits, char *buffer) {
  int32_t wholePart = (int32_t)number;
  uint32_t fractPart = (uint32_t)((number - wholePart) * pow(10, fracDigits));
  sprintf(buffer, "%d.%u", wholePart, fractPart);
}
void readAndFormatData(char *buffer, size_t bufferSize) {
    int currentReading = analogRead(CURRENT_SENSOR_PIN);
    int voltageReading = analogRead(VOLTAGE_SENSOR_PIN);
    
    float voltagePzem = pzem.voltage();
    float currentPzem = pzem.current();

    Serial.println(String(voltagePzem));
    Serial.println(String(currentPzem));

    if (isnan(voltagePzem)) {
        voltagePzem = 0;
    }
    if (isnan(currentPzem)) {
        currentPzem = 0;
    }

    char voltagePzemString[7];
    char currentPzemString[7];

  dtostrf_fast(voltagePzem, 2, voltagePzemString);
  dtostrf_fast(currentPzem, 2, currentPzemString);

  snprintf(buffer, bufferSize, "DC%dA|DC%dV|AC%sA|AC%sV",
           currentReading, voltageReading, currentPzemString, voltagePzemString);
}

TaskHandle_t udpTask;
TaskHandle_t mdnsTask;

void udpSendDataTask(void * parameter) {

  for (;;) {
      digitalWrite(LED_PIN, HIGH);
      
      readAndFormatData(bufferData, sizeof(bufferData));
      udp.beginPacket(udpTargetIP, UDP_PORT);
      udp.print(bufferData);
      Serial.println(bufferData);
      udp.endPacket();
      memset(bufferData, 0, nBuffer);
      digitalWrite(LED_PIN, LOW);

      vTaskDelay(pdMS_TO_TICKS(sendDelayMs));
  }
}

void mdnsTaskFunction(void * parameter) {
  for (;;) {
    unsigned long currentMillis = millis();
    if (currentMillis - LAST_CONNECTION_CHECK > CONNECTION_CHECK_INTERVAL_MS) {
        updateMDNS();
        LAST_CONNECTION_CHECK = currentMillis;
    }
    vTaskDelay(pdMS_TO_TICKS(10)); // Add this line
  }
}

void setup() 
{
  Serial.begin(115200);
  PZEM_SERIAL.begin(9600, SERIAL_8N1, PZEM_RX_PIN, PZEM_TX_PIN);
  analogReadResolution(12); 
  setupPin();
  connectToWiFi(HOTSPOT_SSID,HOTSPOT_PASSWORD);
  setupHttpServer();
  xTaskCreate(udpSendDataTask, "udpSendDataTask",10000, NULL, 2, &udpTask);
  xTaskCreate(mdnsTaskFunction, "mdnsTaskFunction", 10000, NULL, 1, &mdnsTask);
}

void loop() {

}