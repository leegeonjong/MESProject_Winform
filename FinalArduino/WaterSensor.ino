int water_pin = A0;  //수위센서 A0에 연결
int waterlevel = 0;
const int standard = 100;

float prevWaterlevel = 0.0;  // 이전 값을 저장할 변수

void WaterSenser(String process, String lotId) {
  waterlevel = analogRead(A0);
  SendTestData(process,lotId,String(waterlevel));

   // 이전 값과 새로운  값이 다른 경우에만 SendTestData 함수 호출
  if (waterlevel != prevWaterlevel) {
    // 새로운 값을 저장하고 SendTestData 함수 호출
    prevWaterlevel = waterlevel;
    SendTestData(process, lotId, String(waterlevel));
    return;
  } else {
    return;
  }
}
