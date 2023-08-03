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
    processState = true;  //공정이 실행중임
    LEDstatus[processNum] = "Y";

    isTemperatureSensorCalled = false;
    isWaterSenserCalled = false;
  }
  // 명령어가 On 일때 : 프로세스(공정) 정지-->작동
  else if (action == "On") {
    // 공정이 실행중이였다면 yello 켜기
    if (processState == true) {
      digitalWrite(LedRed[processNum], LOW);
      digitalWrite(LedGreen[processNum], LOW);
      digitalWrite(LedYellow[processNum], HIGH);
      LEDstatus[processNum] = "Y";
      processState = false;
    }
    //공정이 대기중이였다면 green 켜기
    else {
      digitalWrite(LedRed[processNum], LOW);
      digitalWrite(LedGreen[processNum], HIGH);
      digitalWrite(LedYellow[processNum], LOW);
      LEDstatus[processNum] = "G";
    }
    startTime[processNum] = millis();
    timerStarted[processNum] = true;
  }
  // 명령어가 Off 일때 : 프로세스(공정) 작동-->정지
  else if (action == "Off") {
    digitalWrite(LedRed[processNum], HIGH);
    digitalWrite(LedGreen[processNum], LOW);
    digitalWrite(LedYellow[processNum], LOW);
    LEDstatus[processNum] = "R";

    timerDuration = timerDuration - (millis() - startTime[processNum]);
    timerStarted[processNum] = false;  // 타이머 상태 초기화

  }
}
