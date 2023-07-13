#define WaterSensor A0  // A0핀을 수심센서로 설정
#include <LiquidCrystal_I2C.h>


LiquidCrystal_I2C lcd1(0x27, 16, 2);  // (LCD I2C 주소, 16자, 2라인)
LiquidCrystal_I2C lcd2(0x3F, 16, 2);




int Process1Led1 = 52;
int Process1Led2 = 53;
int Process1Motor = 51;
int Process1Sw = 50;

int ProcessSw[] = { 22, 23, 24, 25, 26, 27 };  //설비 정지 버튼
int LedRed[] = { 30, 32, 7, 41, 46, 49 };      //설비 정지
int LedGreen[] = { 31, 34, 39, 42, 47, 50 };   //설비 준비
int LedYellow[] = { 33, 35, 40, 43, 48, 51 };  //설비 가동중

unsigned long startTime = 0;                // 시작시간
bool timerStarted = false;                  // 타이머 시작 bool
const unsigned long timerDuration = 10000;  // 10 seconds



void setup() {
  Serial.begin(9600);  // Serial monitor 구동 전원입력
  pinMode(WaterSensor, INPUT);

  lcd1.init();       // LCD 초기화
  lcd1.backlight();  // LCD 백라이트 ON
  lcd2.init();       // LCD 초기화
  lcd2.backlight();

  Serial.begin(9600);

  for (int i = 0; i < 6; i++) {
    pinMode(ProcessSw[i], INPUT_PULLUP);
    pinMode(LedRed[i], OUTPUT);
    pinMode(LedGreen[i], OUTPUT);
    pinMode(LedYellow[i], OUTPUT);
  }
}

String action = "";   //공정상태
String rest = "";     //나머지
String process = "";  // 공정명
String lotid = "";    // lotid

void loop() {
  for (int i = 0; i < 6; i++) {
    digitalWrite(LedRed[i], HIGH);
    // digitalWrite(LedGreen[i], HIGH);
    // digitalWrite(LedYellow[i], HIGH);
  }

  // $Run,Mix,213 명령 받고 이렇게 돌려주도록 한다

  if (Serial.available() > 0) {
    String line = Serial.readStringUntil('\n');
    line.trim();  // trim() 은 void 리턴.
    if (line.startsWith("$")) {
      action = line.substring(1, line.indexOf(","));
      rest = line.substring(line.indexOf(",") + 1);
      process = rest.substring(0, line.indexOf(","));
      lotid = rest.substring(line.indexOf(",") + 0);
      int ProcessNum = ProcessName(process);
      if (action == "Run") {
        SendRecieve(process, lotid);
        SendStart(process, lotid);

        startTime = millis();  // 타이머 시작 시간 저장
        timerStarted = true;   // 타이머 시작 상태 설정
      }


      else if (action == "On") {
        //작동중이였다면 노란색 아니라면 초록색 켜기
        digitalWrite(LedRed[ProcessNum], LOW);
        digitalWrite(LedGreen[ProcessNum], HIGH);
        digitalWrite(LedYellow[ProcessNum], LOW);
        SendContinue(process, lotid);

      } else if (action == "Off") {
        digitalWrite(LedRed[ProcessNum], HIGH);
        digitalWrite(LedGreen[ProcessNum], LOW);
        digitalWrite(LedYellow[ProcessNum], LOW);
        SendStop(process, lotid);
      }
    }
  }
  if (timerStarted && millis() - startTime >= timerDuration) {
    SendEnd(process, lotid);
    timerStarted = false;  // 타이머 상태 초기화
  }




  //  WaterSenser();

  // Process1(Process1Led1, Process1Led2, Process1Motor, Process1Sw);


  // UltrasonicSensor();
}