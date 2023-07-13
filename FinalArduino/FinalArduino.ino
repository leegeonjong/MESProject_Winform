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
  if (Serial.available() > 0) {
    String recv = Serial.readStringUntil('\n');
    recv.trim();

    if (recv.startsWith("$")) {
      String cmd = recv.substring(1, recv.indexOf(","));
      String process = recv.substring(recv.indexOf(",") + 1);

      if (cmd == "On") {
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