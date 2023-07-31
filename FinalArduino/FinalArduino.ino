#define WaterSensor A0  // A0핀을 수심센서로 설정
#include <LiquidCrystal_I2C.h>


LiquidCrystal_I2C lcd(0x27, 16, 2);  // (LCD I2C 주소, 16자, 2라인)


int ProcessSw[] = { 22, 23, 24, 25, 26, 27 };  //설비 정지 버튼
int LedRed[] = { 30, 32, 7, 41, 46, 49 };      //설비 정지
int LedGreen[] = { 31, 34, 39, 42, 47, 50 };   //설비 준비
int LedYellow[] = { 33, 35, 40, 43, 48, 51 };  //설비 가동중
String LEDstatus[] = { "G", "G", "G", "G", "G", "G" };
int Lot_Count = 0;

struct MyStruct {
  String action;
  String process;
  String lotid;
  long starttime;
};

MyStruct myArray[] = {
  { "", "", "", 0 },
  { "", "", "", 0 },
  { "", "", "", 0 },
  { "", "", "", 0 },
  { "", "", "", 0 },
  { "", "", "", 0 }
};

const int numProcesses = 6;  //공정 개수
bool buttonState[numProcesses] = { false, false, false, false, false, false };
bool prevButtonState[numProcesses] = { false, false, false, false, false, false };
bool timerStarted[numProcesses] = { false, false, false, false, false, false };
unsigned long startTime[numProcesses] = { 0, 0, 0, 0, 0, 0 };
unsigned long timerDuration = 10000;     // 10 seconds
bool isWaterSenserCalled = false;        // WaterSenser 함수가 한 번 호출되었는지 여부를 저장하는 변수
bool isTemperatureSensorCalled = false;  // TemperatureSensor 함수가 한 번 호출되었는지 여부를 저장하는 변수

void setup() {
  Serial.begin(9600);  // Serial monitor 구동 전원입력
  pinMode(WaterSensor, INPUT);
  lcd.begin(16, 2);
  lcd.init();       // LCD 초기화
  lcd.backlight();  // LCD 백라이트 ON

  for (int i = 0; i < numProcesses; i++) {
    pinMode(ProcessSw[i], INPUT_PULLUP);
    pinMode(LedRed[i], OUTPUT);
    pinMode(LedGreen[i], OUTPUT);
    pinMode(LedYellow[i], OUTPUT);
    digitalWrite(LedGreen[i], HIGH);
  }
}

String action = "";   //공정상태
String rest = "";     //나머지
String process = "";  // 공정명
String lotid = "";    // lotid

void loop() {
  LCDSet(LEDstatus);
  // 버튼을 눌렀을 때
  for (int i = 0; i < numProcesses; i++) {
    buttonState[i] = digitalRead(ProcessSw[i]);

    // 버튼의 눌림 상태 변화를 감지하여 한 번만 실행
    if (buttonState[i] != prevButtonState[i]) {
      if (buttonState[i] == LOW && prevButtonState[i] == HIGH) {  // Falling Edge

        if (timerStarted[i]) {
          digitalWrite(LedRed[i], HIGH);
          digitalWrite(LedGreen[i], LOW);
          digitalWrite(LedYellow[i], LOW);
          LEDstatus[i] = "R";

          SendStop(myArray[i].process, myArray[i].lotid);
          timerDuration = timerDuration - (millis() - startTime[i]);
          timerStarted[i] = false;  // 타이머 상태 초기화
        } else {
          digitalWrite(LedRed[i], LOW);
          digitalWrite(LedGreen[i], LOW);
          digitalWrite(LedYellow[i], HIGH);
          LEDstatus[i] = "Y";
          SendContinue(myArray[i].process, myArray[i].lotid);
          startTime[i] = millis();
          timerStarted[i] = true;
        }
      }
      prevButtonState[i] = buttonState[i];
    }
  }


  // 윈폼에서 통신을 받는 곳
  if (Serial.available() > 0) {
    String line = Serial.readStringUntil('\n');
    line.trim();  // trim() 은 void 리턴.
    if (line.startsWith("$")) {
      action = line.substring(1, line.indexOf(","));
      rest = line.substring(line.indexOf(",") + 1);
      process = rest.substring(0, rest.indexOf(","));
      lotid = rest.substring(rest.indexOf(",") + 1);
      Processstart(action, process, lotid);
    }
  }

  // 타이머 상태 확인 및 처리
  for (int i = 0; i < numProcesses; i++) {
    if (timerStarted[i] && millis() - startTime[i] >= timerDuration) {
      SendEnd(myArray[i].process, myArray[i].lotid);
      timerStarted[i] = false;  // 타이머 상태 초기화
      timerDuration = 10000;    //10초로 초기화
      digitalWrite(LedRed[i], LOW);
      digitalWrite(LedGreen[i], HIGH);
      digitalWrite(LedYellow[i], LOW);
      LEDstatus[i] = "G";
    }

    if (timerStarted[i]) {
      switch (i) {
        case 0:  // 첫번째 공정이면 제공 더하기
          UltrasonicSensor(myArray[i].process, myArray[i].lotid);
          break;
        case 5:  // 마지막 공정이면 제공 빼기
          UltrasonicSensorMinus(myArray[i].process, myArray[i].lotid);
          break;
        case 2:  // 찌기 공정일떄 TemperatureSensor 온도 측정
          if (!isTemperatureSensorCalled) {
            TemperatureSensor(myArray[i].process, myArray[i].lotid);
            isTemperatureSensorCalled = true;  ///TemperatureSensor 함수가 호출되었음을 표시
          }
          break;
        case 3:  // 튀기기 공정이면 waterlever로 팜유 용량 측정
          if (!isWaterSenserCalled) {
            WaterSenser(myArray[i].process, myArray[i].lotid);
            isWaterSenserCalled = true;  // WaterSenser 함수가 호출되었음을 표시
          }
          break;
      }
    }
  }  //end timer for



}  //end loop
