#include "DHT.h"
#define DHTPIN 17      // 출력에 연결된 핀번호
#define DHTTYPE DHT11  // DHT시리즈중 DHT11 선택

DHT dht(DHTPIN, DHTTYPE);     // DHT 객체 생성
int prevTemperature = 0;  // 이전 온도 값을 저장할 변수

void TemperatureSensor(String process, String lotId) {
  int prevTemperature = 0;
  dht.begin();
  int temperature = dht.readTemperature();  // 온도를 측정 (섭씨 ℃)

  // 이전 온도 값과 새로운 온도 값이 다른 경우에만 SendTestData 함수 호출
  if (temperature != prevTemperature) {
    // 새로운 온도 값을 저장하고 SendTestData 함수 호출
    prevTemperature = temperature;
    SendTestData(process, lotId, String(temperature));
    return;
  } else {
    return;
  }
}