#define TRIG 27 //TRIG 핀 설정 (초음파 보내는 핀)

#define ECHO 25 //ECHO 핀 설정 (초음파 받는 핀)

int count = 0;

void UltrasonicSensor(){
  pinMode(TRIG, OUTPUT);

  pinMode(ECHO, INPUT);

  long duration, distance;



  digitalWrite(TRIG, LOW);
  delayMicroseconds(2);
  digitalWrite(TRIG, HIGH);
  delayMicroseconds(10);
  digitalWrite(TRIG, LOW);

  duration = pulseIn (ECHO, HIGH); //물체에 반사되어돌아온 초음파의 시간을 변수에 저장합니다.

  distance = duration * 17 / 1000; 


  Serial.print(distance); //측정된 물체로부터 거리값(cm값)을 보여줍니다.

  Serial.println(" Cm");

  if(distance<10){
    count++;
    Serial.print(count);
    Serial.println("개 통과");
  }



  delay(1000); //1초마다 측정값을 보여줍니다.
}