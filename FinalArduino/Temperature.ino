#include "DHT.h"
#define DHTPIN 2       // 출력에 연결된 핀번호
#define DHTTYPE DHT11  // DHT시리즈중 DHT11 선택

DHT dht(DHTPIN, DHTTYPE);  // DHT 객체 생성

void TemperatureSensor(String process) {
  dht.begin();
  float temperature = dht.readTemperature();  // 온도를 측정 (섭씨 ℃)

  SendTestData(process,String(temperature));
}