void Processstart(String action, String process, String lotid) {
  int processNum = ProcessName(process);
  
  switch (action) {
    case "Run": // 명령어가 Run 일때 작업 실행
      startTime[processNum] = millis();
      timerStarted[processNum] = true;
      myArray[processNum] = { action, process, lotid, startTime[processNum] };
      SendRecieve(myArray[processNum].process, myArray[processNum].lotid);
      SendStart(myArray[processNum].process, myArray[processNum].lotid);

      digitalWrite(LedRed[processNum], LOW);
      digitalWrite(LedGreen[processNum], LOW);
      digitalWrite(LedYellow[processNum], HIGH);
      LEDstatus[processNum] = "Y";
      break;

    case "Good": // 명령어가 Good 일때 : 검사 통과
      // 아무 작업 없음
      break;

    case "Fail": // 명령어가 Fail 일때 : 검사 실패 --> 
      LEDstatus[processNum] = "F";
      // lcd 에 F 표시 
      // 서보모터 돌리기 
      break;

    case "On": // 명령어가 On 일때 : 프로세스(공정) 정지-->작동
      digitalWrite(LedRed[processNum], LOW);
      digitalWrite(LedGreen[processNum], LOW);
      digitalWrite(LedYellow[processNum], HIGH);
      startTime[processNum] = millis();
      timerStarted[processNum] = true;
      LEDstatus[processNum] = "Y";
      SendContinue(myArray[processNum].process, myArray[processNum].lotid);
      break;

    case "Off": // 명령어가 Off 일때 : 프로세스(공정) 작동-->정지
      digitalWrite(LedRed[processNum], HIGH);
      digitalWrite(LedGreen[processNum], LOW);
      digitalWrite(LedYellow[processNum], LOW);
      LEDstatus[processNum] = "R";

      timerDuration = timerDuration - (millis() - startTime[processNum]);
      timerStarted[processNum] = false;  // 타이머 상태 초기화

      SendStop(myArray[processNum].process, myArray[processNum].lotid);
      break;

    default:
      // 예외 처리 - 알 수 없는 명령어에 대한 처리
      break;
  }
}
