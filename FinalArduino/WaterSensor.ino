int water_pin = A0;  //수위센서 A0에 연결
int waterlevel = 0;
void WaterSenser() {
  waterlevel = analogRead(A0);

  if (waterlevel > 10 && waterlevel < 100) {
    Serial.println("너무 적어");
  }
  else if(waterlevel >= 100){
    Serial.println("적정량");
  }
}
