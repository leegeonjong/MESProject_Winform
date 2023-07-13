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
  //  WaterSenser();

  Process1(Process1Led1, Process1Led2, Process1Motor, Process1Sw);
void loop(){

 UltrasonicSensor();
}