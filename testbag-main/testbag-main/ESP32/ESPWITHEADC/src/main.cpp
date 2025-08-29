#include <Arduino.h>
#include <SPI.h>
#include <Adafruit_ADS1X15.h>
#include <WiFi.h>
#include <WiFiUdp.h>
#include <string.h>
#include <HardwareSerial.h>
#include <PZEM004Tv30.h>
#include <ESPmDNS.h>
#include <WebServer.h>


Adafruit_ADS1115 ads;
#define LED 2

#if defined(ESP32)
PZEM004Tv30 pzem(Serial2, 16, 17);
#else
PZEM004Tv30 pzem(Serial2);
#endif

const int updPort = 8080;
const int httpPort = 80; 

const int readingSpeed = 50 ;
const int startDelay = 500;

const int VOLTAGE_SENSOR_PIN = 32;
const int CURRENT_SENSOR_PIN = 35;
const int csPin = 15;

WebServer server(httpPort);
WiFiUDP udp;

#define nBuffer 100
char bufferData[nBuffer] = "ESP32";

float voltagePzem ;
float currentPzem ;
float powerPzem;
float energyPzem;  

String voltageStringPzem ;
String currentStringPzem ;
String powerStringPzem ;
String energyStringPzem ;

IPAddress computerIP;

unsigned long lastConnectionCheck = 0;
unsigned long connectionCheckInterval = 10000;
int sequenceNumber = 0;

void connectToWiFi(const char* ssid , const char* password) {
  WiFi.begin(ssid, password);
  while (WiFi.status() != WL_CONNECTED) {
    digitalWrite(LED, HIGH);
    delay(startDelay);
    Serial.println(".\n");
    digitalWrite(LED, LOW);
  }
  Serial.print("Connected to : ");
  Serial.println(WiFi.SSID());
  Serial.println("IP Address : ");
  Serial.println(WiFi.localIP());
  udp.begin(updPort);
}

void initMDNS(){
  if(!MDNS.begin("ESP32")){
    Serial.println("Error starting mDNS");
    return;
  }
  Serial.println("mDNS started");
  MDNS.addService("udp","tcp",updPort);
}

void handleWifiConfig(){
  String ssid = server.arg("ssid");
  String password = server.arg("password");

  server.send(200, "text/plain", "Wi-Fi credentials received.");
  Serial.println("Received Wi-Fi credentials:");
  Serial.print("SSID: ");
  Serial.println(ssid);
  Serial.print("Password: ");
  Serial.println(password);

  connectToWiFi(ssid.c_str(), password.c_str());
}

void setupHttpServer(){
  server.on("/wifiConfig",handleWifiConfig);
  server.begin();
}

void checkConnection() {
  if (millis() - lastConnectionCheck > connectionCheckInterval) {
    lastConnectionCheck = millis();
    if (WiFi.status() != WL_CONNECTED) {
      Serial.println("Disconnected. Attempting to reconnect...");
      WiFi.beginSmartConfig();
    }
  }
}

void setup() {
  Serial.begin(115200);
  SPI.begin();
  WiFi.beginSmartConfig();
  ads.begin(0x48);
  ads.setGain(GAIN_TWO);
  ads.setDataRate(860);
  pinMode(csPin, OUTPUT); // Set the CS pin as an output
  digitalWrite(csPin, HIGH); // Set the CS pin high to deselect the ADS1115 module

  WiFi.mode(WIFI_STA);

  initMDNS();
  setupHttpServer();

  pinMode(LED, OUTPUT);
}

void loop() {
  server.handleClient();

  int16_t voltage = ads.readADC_SingleEnded(VOLTAGE_SENSOR_PIN);
  float voltage_volts = voltage * 0.0001875;  // convert to volts

  int16_t current = ads.readADC_SingleEnded(CURRENT_SENSOR_PIN);
  float current_volts = current * 0.0001875;

  voltagePzem = pzem.voltage();
  currentPzem = pzem.current();

  if(isnan(voltagePzem)){ 
    voltagePzem = 0 ;
    Serial.println("Cannot Read Voltage from PZEM");
    } 
  if(isnan(currentPzem)) { 
    currentPzem = 0 ;
    Serial.println("Cannot Read Current from PZEM");
    } 
  String currentString = String(current);
  String voltageString = String(voltage);
  voltageStringPzem = String(voltagePzem);
  currentStringPzem = String(currentPzem);

  // - - - - - - SEND DATA TO COMPUTER - - - - - - - //
   sprintf(bufferData, "S%d|DC%sA|DC%sV|AC%sA|AC%sV",
    sequenceNumber,currentString.c_str(), voltageString.c_str(), currentStringPzem.c_str(), voltageStringPzem.c_str());
  Serial.println(bufferData);

  checkConnection(); // Check and maintain Wi-Fi connection

  // First
  digitalWrite(LED,HIGH);
  udp.beginPacket(computerIP,updPort);
  udp.print(bufferData);
  udp.endPacket();
  memset(bufferData,0,nBuffer);
  digitalWrite(LED,LOW);

  // Again
  bool success = false;
  for (int i = 0; i < 5; i++) {
    digitalWrite(LED, HIGH);
    udp.beginPacket(computerIP, updPort);
    udp.print(bufferData);
    udp.endPacket();
    digitalWrite(LED, LOW);

    memset(bufferData, 0, nBuffer);
    int packetSize = udp.parsePacket();
    if (packetSize > 0) {
      int len = udp.read(bufferData, sizeof(bufferData));
      if (len > 0) {
        bufferData[len] = '\0';
        Serial.print("Received ACK from computer: ");
        Serial.println(bufferData);
        if (strncmp(bufferData, "ACK", 3) == 0) {
          int receivedSeqNum = atoi(bufferData + 3);
          if (receivedSeqNum == sequenceNumber) {
            success = true;
            break;
          }
        }
      }
    }
    delay(1000);
  }
  if (success) { Serial.println("Packet successfully delivered."); }
  else { Serial.println("Error: Packet not acknowledged."); }
  sequenceNumber++;
  delay(1000);
}