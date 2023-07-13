#include "DHT.h"

#define DHTPIN 2     // 출력에 연결된 핀번호
#define DHTTYPE DHT11   // DHT시리즈중 DHT11 선택


DHT dht(DHTPIN, DHTTYPE);   // DHT 객체 생성

void TemperatureSensor(){
  delay(1000);
    dht.begin();
     float h = dht.readHumidity();  // 습도를 측정
    float t = dht.readTemperature();   // 온도를 측정 (섭씨 ℃)

if (isnan(h) || isnan(t)) {              
    Serial.println(F("센서와 연결되지 않았습니다"));
    return;
  }
    Serial.print("temp : ");
    Serial.println(t);
    Serial.print("humi : ");
    Serial.println(h);

    if(t<30){
      Serial.println("온도가 너무 낮습니다");
    }
    

}