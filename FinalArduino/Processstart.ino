void Processstart(String action, String process, String lotid) {
  int processNum = ProcessName(process);
  // 명령어가 Run 일때 작업 실행
  if (action == "Run") {
    startTime[processNum] = millis();
    timerStarted[processNum] = true;
    myArray[processNum] = { action, process, lotid, startTime[processNum] };
    SendRecieve(myArray[processNum].process, myArray[processNum].lotid);
    SendStart(myArray[processNum].process, myArray[processNum].lotid);

    digitalWrite(LedRed[processNum], LOW);
    digitalWrite(LedGreen[processNum], LOW);
    digitalWrite(LedYellow[processNum], HIGH);
    LEDstatus[processNum] = "Y";
  }  
  // 명령어가 On 일때 : 프로세스(공정) 정지-->작동
  else if (action == "On") {
    digitalWrite(LedRed[processNum], LOW);
    digitalWrite(LedGreen[processNum], LOW);
    digitalWrite(LedYellow[processNum], HIGH);
    startTime[processNum] = millis();
    timerStarted[processNum] = true;
    LEDstatus[processNum] = "Y";
    SendContinue(myArray[processNum].process, myArray[processNum].lotid);
  }
  // 명령어가 Off 일때 : 프로세스(공정) 작동-->정지
  else if (action == "Off") {
    digitalWrite(LedRed[processNum], HIGH);
    digitalWrite(LedGreen[processNum], LOW);
    digitalWrite(LedYellow[processNum], LOW);
    LEDstatus[processNum] = "R";

    timerDuration = timerDuration - (millis() - startTime[processNum]);
    timerStarted[processNum] = false;  // 타이머 상태 초기화

    SendStop(myArray[processNum].process, myArray[processNum].lotid);
  }
}
