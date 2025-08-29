#include <Arduino.h>
#include <string.h>
#include <PZEM004Tv30.h>

// !!! CAREFUL! CMD NEEDS TO ADD isCommand()]
#define CMD_INFO "?"           // !!! CAREFUL! CMD NEEDS TO ADD isCommand()
#define _DEBUG_SERIAL_ 0
#define STX ':'
#define ETX '\n'
#define ACK '*'
#define NAK '!'

String inputString = "";      // a String to hold incoming data
bool stringComplete = false;  // whether the string is complete
bool STX_COME = false;
int val;

#define nBuffer 100
char bufferData[nBuffer] = "ArduinoNano";

float voltagePzem ;
float currentPzem ;
String voltageStringPzem ;
String currentStringPzem ;

SoftwareSerial pzemSWSerial(11, 12);
PZEM004Tv30 pzem;
/*
  -----------------------------------------------------------------------------
  SETUP
  -----------------------------------------------------------------------------
*/
void setup() {
  //้
  Serial.begin(115200);
  pzem = PZEM004Tv30(pzemSWSerial);
  Serial.println("Connecting");
}  // SETUP END.

/*
  ------------------------------------------------------------------------
  Serial event
  ------------------------------------------------------------------------
*/
void serialEvent() {
  if (Serial.available()) {
    // get the new byte:
    char inChar = (char)Serial.read();
#if _DEBUG_SERIAL_
    Serial.println(inChar);
#endif

    // add it to the inputString:
    if (STX_COME) {
      if (inChar == ETX) {
        stringComplete = true;
#if _DEBUG_SERIAL_
        Serial.println("ETX come.");
#endif
        return;
      }
      if (inChar != STX && inChar != '\r' && inChar != ETX) {
        inputString += inChar;
      }
      return;
    }

    // if the incoming character is a newline, set a flag so the main loop can
    // do something about it://
    if (inChar == STX) {
      STX_COME = true;
      stringComplete = false;
      inputString = "";
#if _DEBUG_SERIAL_
      Serial.println("STX come.");
#endif
      return;
    }


  }
}
//
void ClearSerialEvent(bool flag) {
  if (flag) {
#if _DEBUG_SERIAL_
    Serial.println("Clear serial event.");
#endif
    STX_COME = false;
    stringComplete = false;
    inputString = "";
  }
}

void info(bool flag) {
  if (flag) {
    int currentReading = analogRead(A2);
    int voltageReading = analogRead(A3);
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
   if (isnan(currentReading)) {
      currentReading = 0 ;
      Serial.println("Cannot Read Current from ACS712");
      }
    if (isnan(voltageReading)) {
      voltageReading = 0 ;
      Serial.println("Cannot Read Voltage from Sensor");
      }

    String currentString = String(currentReading);
    String voltageString = String(voltageReading);
    voltageStringPzem = String(voltagePzem);
    currentStringPzem = String(currentPzem);

    char bufferData[nBuffer];
    sprintf(bufferData,"CurrentDc : %s A | VoltageDc : %s V | CurrentAc : %s A | VoltageAc : %s V",
          currentString.c_str(), voltageString.c_str(), currentStringPzem.c_str(),voltageStringPzem.c_str());
    Serial.println(bufferData);
  }
}



void loop() {
  serialEvent();
  info(stringComplete && inputString.equals(CMD_INFO));

  ClearSerialEvent(stringComplete);
}  // LOOP END.

