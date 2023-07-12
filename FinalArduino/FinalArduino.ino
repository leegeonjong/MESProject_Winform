void setup() {
  Serial.begin(9600);   // Serial monitor 구동 전원입력
  pinMode( A0,   INPUT); // A0핀을 입력으로 설정

}
void loop(){
 WaterSenser();
 
}