#define WaterSensor A0  // A0핀을 수심센서로 설정
int Process1Led1 = 52;
int Process1Led2 = 53;
int Process1Motor = 51;
int Process1Sw = 50;

int ProcessSw[] = { 22, 23, 24, 25, 26, 27 };  //설비 정지 버튼
int LedRed[] = { 30, 32, 38, 41, 46, 49 };     //설비 정지
int LedGreen[] = { 31, 34, 39, 42, 47, 50 };   //설비 가동중
int LedYellow[] = { 33, 35, 40, 43, 48, 51 };  //설비 표현


void setup() {
  Serial.begin(9600);  // Serial monitor 구동 전원입력
  pinMode(WaterSensor, INPUT);

  for (int i = 0; i < 6; i++) {
    pinMode(ProcessSw[i], INPUT_PULLUP);
    pinMode(LedRed[i], OUTPUT);
    pinMode(LedGreen[i], OUTPUT);
    pinMode(LedYellow[i], OUTPUT);
  }
}

void loop() {
  for (int i = 0; i < 6; i++) {
    digitalWrite(LedRed[i], HIGH);
    // digitalWrite(LedGreen[i], HIGH);
    // digitalWrite(LedYellow[i], HIGH);
  }

  String action = "";   //공정상태
  String rest = "";     //나머지
  String process = "";  // 공정명
  String lotid = "";    // lotid
  // $Run,Mix,213 명령 받고 이렇게 돌려주도록 한다

  if (Serial.available() > 0) {  // <- 수신 버퍼를 비우려면 while(Serial.available()) 사용해야 한다.  https://www.baldengineer.com/when-do-you-use-the-arduinos-to-use-serial-flush.html
    String line = Serial.readStringUntil('\n');
    line.trim();  // trim() 은 void 리턴.
    if (line.startsWith("$")) {
      action = line.substring(1, line.indexOf(","));
      rest = line.substring(line.indexOf(",") + 1);
      process = rest.substring(0, line.indexOf(","));
      lotid = rest.substring(line.indexOf(",") + 0);
      if (action == "Run") {
        SendRecieve(process, lotid);
        SendStart(process, lotid);
        // 프로세스 시작
        // 10초 타이머 시작
        SendEnd(process, lotid);
      } else if (action == "On") {
        SendOn(process, lotid);
        for (int i = 0; i < 6; i++) {
          digitalWrite(LedRed[i], HIGH);
        }
      } else if (action == "Off") {
        SendOff(process, lotid);
        for (int i = 0; i < 6; i++) {
          digitalWrite(LedRed[i], LOW);
        }
      }
    }
  }

  //  WaterSenser();

  // Process1(Process1Led1, Process1Led2, Process1Motor, Process1Sw);


  // UltrasonicSensor();
}