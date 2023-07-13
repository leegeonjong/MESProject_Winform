#define WaterSensor A0  // A0핀을 수심센서로 설정
int Process1Led1 = 52;
int Process1Led2 = 53;
int Process1Motor = 51;
int Process1Sw = 50;

void setup() {
  Serial.begin(9600);  // Serial monitor 구동 전원입력
  pinMode(WaterSensor, INPUT);

  pinMode(Process1Sw, INPUT_PULLUP);
  pinMode(Process1Led1, OUTPUT);
  pinMode(Process1Led2, OUTPUT);
  pinMode(Process1Motor, OUTPUT);
}
void loop() {
  action = "";   //공정상태
  rest = "";     //나머지
  process = "";  // 공정명
  lotid = "";    // lotid
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
        lcd.print("run");
        Serial.println("$Recieve,lotstatus,lotid");
        Serial.println(action);
        Serial.println(process);
        Serial.println(lotid);
      }
      else if (cmd == "On") {
        digitalWrite(Process1Led1, HIGH);
        digitalWrite(Process1Led2, LOW);
      } else if (cmd == "Off") {
        digitalWrite(Process1Led1, LOW);
        digitalWrite(Process1Led2, HIGH);
      }

    }
  }

  //  WaterSenser();

  // Process1(Process1Led1, Process1Led2, Process1Motor, Process1Sw);


  // UltrasonicSensor();
}