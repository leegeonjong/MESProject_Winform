
void Processstart(String action, String process, String lotid) {
  int processNum = ProcessName(process);
  if (action == "Run") {

    //검사를 하는 공정이면
    switch (processNum) {
      case 0:
        UltrasonicSensor();  //첫번째 공정이 시작되면 개수세기
        break;
      case 3:
        WaterSenser();  //튀기기 공정이면 waterlever로 팜유 측정
        break;
      case 5:
        UltrasonicSensorMinus();  //마지막 공정이 시작되면 개수 빼기
        break;
    }
    
    startTime[processNum] = millis();
    timerStarted[processNum] = true;
    myArray[processNum] = { action, process, lotid, startTime[processNum] };
    SendRecieve(myArray[processNum].process, myArray[processNum].lotid);
    SendStart(myArray[processNum].process, myArray[processNum].lotid);
    digitalWrite(LedRed[processNum], LOW);
    digitalWrite(LedGreen[processNum], LOW);
    digitalWrite(LedYellow[processNum], HIGH);
  }

  else if (action == "On") {
    digitalWrite(LedRed[processNum], LOW);
    digitalWrite(LedGreen[processNum], LOW);
    digitalWrite(LedYellow[processNum], HIGH);
    startTime[processNum] = millis();
    timerStarted[processNum] = true;

    SendContinue(myArray[processNum].process, myArray[processNum].lotid);
  } else if (action == "Off") {
    digitalWrite(LedRed[processNum], HIGH);
    digitalWrite(LedGreen[processNum], LOW);
    digitalWrite(LedYellow[processNum], LOW);
    timerDuration = timerDuration - (millis() - startTime[processNum]);
    timerStarted[processNum] = false;  // 타이머 상태 초기화

    SendStop(myArray[processNum].process, myArray[processNum].lotid);
  }
}
