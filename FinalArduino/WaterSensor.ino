int water_pin = A0;  //수위센서 A0에 연결
int waterlevel = 0;
const int standard = 100;

void WaterSenser() {
  waterlevel = analogRead(A0);
  if (waterlevel >= standard) {
    Serial.println(true);
  } else if (waterlevel < standard) {
    Serial.println(false);
  }
}
