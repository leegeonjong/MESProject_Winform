int TRIG_Plus = 10;   //더하기 TRIG 핀 설정 (초음파 보내는 핀)
int ECHO_Plus = 11;   //더하기 ECHO 핀 설정 (초음파 받는 핀)
int TRIG_Minus = 16;  //빼기 TRIG 핀 설정 (초음파 보내는 핀)
int ECHO_Minus = 15;  //빼기 ECHO 핀 설정 (초음파 받는 핀)

const int speedOfSound = 34300;
int Lot_Count = 0;

bool minusToggle = false;
bool plusToggle = false;

void UltrasonicSensor(String process) {
  pinMode(TRIG_Plus, OUTPUT);
  pinMode(ECHO_Plus, INPUT);

  long durationPlus, distancePlus;

  digitalWrite(TRIG_Plus, LOW);

  delayMicroseconds(2);
  digitalWrite(TRIG_Plus, HIGH);

  delayMicroseconds(10);
  digitalWrite(TRIG_Plus, LOW);


  durationPlus = pulseIn(ECHO_Plus, HIGH);
 distancePlus = durationPlus * 17 / 1000;

  if (distancePlus < 5 && distancePlus != 0) {
    if (Lot_Count >= 0 && !plusToggle) {
      plusToggle = true;
      Lot_Count++;
      SendTestData(process, String(Lot_Count));
      return;
    }
  } else {
    plusToggle = false;
  }
}

void UltrasonicSensorMinus(String process) {
  pinMode(TRIG_Minus, OUTPUT);
  pinMode(ECHO_Minus, INPUT);

  long durationMinus, distanceMinus;

  digitalWrite(TRIG_Minus, LOW);
  delayMicroseconds(2);
  digitalWrite(TRIG_Minus, HIGH);
  delayMicroseconds(10);
  digitalWrite(TRIG_Minus, LOW);

  durationMinus = pulseIn(ECHO_Minus, HIGH);
  distanceMinus = durationMinus * 17 / 1000;

  if (distanceMinus < 3 && distanceMinus != 0) {
    if (Lot_Count > 0 && !minusToggle) {
      minusToggle = true;
      Lot_Count--;
      SendTestData(process, String(Lot_Count));
    }
  } else {
    minusToggle = false;
  }
}