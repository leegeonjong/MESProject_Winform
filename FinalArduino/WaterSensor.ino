int water_pin = A0;  //수위센서 A0에 연결
int waterlevel = 0;
const int standard = 100;

void WaterSenser(String process, String lotId) {
  waterlevel = analogRead(A0);
  SendTestData(process,lotId,String(waterlevel));
}
