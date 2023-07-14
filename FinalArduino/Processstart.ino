
void Processstart(String action, String process, String lotid) {
  int processNum = ProcessName(process);
  if (action == "Run") {
    //검사를 하는 공정이면
    if (processNum == 3) {
      //튀기기 공정이면 waterlever로 팜유 측정
      WaterSenser();
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
