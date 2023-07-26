int water_pin = A0;  //수위센서 A0에 연결
int waterlevel = 0;
const int standard = 100;

void WaterSenser(String process) {
  waterlevel = analogRead(A0);
  //true flase 판별을 아두이노에서 하는건가
  //윈폼에서 받아서 하는건가 
  //용량이 기준치보다 적은지 많은지 값만 보내고 윈폼에서 판단해도 될듯 그 값받아서 그래프 그리게 
  // if (waterlevel >= standard) {
  //   Serial.println(true);
  // } else if (waterlevel < standard) {
  //   Serial.println(false);
  // }
  SendTestData(process,String(waterlevel));
}
