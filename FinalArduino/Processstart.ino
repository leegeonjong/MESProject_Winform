
void Processstart(String action, String process, String lotid) {
  int processNum = ProcessName(process);
  // if (action == "Run") {
  //     Serial.println(action);
  //     Serial.println(process);
  //     Serial.println(lotid);
  //   if (process == "Mix") {
  //     startTimeMix = millis();
  //     timerStartedMix = true;
  //     myArray[0] = { action, process, lotid, startTimeMix };
  //     SendRecieve(myArray[0].process, myArray[0].lotid);
  //     SendStart(myArray[0].process, myArray[0].lotid);
  //   } else if (process == "Shape") {
  //     startTimeShape = millis();
  //     timerStartedShape = true;
  //     myArray[1] = { action, process, lotid, startTimeShape };
  //     SendRecieve(myArray[1].process, myArray[1].lotid);
  //     SendStart(myArray[1].process, myArray[1].lotid);
  //   } else if (process == "Steam") {
  //     startTimeSteam = millis();
  //     timerStartedSteam = true;
  //     myArray[2] = { action, process, lotid, startTimeSteam };
  //     SendRecieve(myArray[2].process, myArray[2].lotid);
  //     SendStart(myArray[2].process, myArray[2].lotid);
  //   } else if (process == "Fry") {
  //     startTimeFry = millis();
  //     timerStartedFry = true;
  //     myArray[3] = { action, process, lotid, startTimeFry };
  //     SendRecieve(myArray[3].process, myArray[3].lotid);
  //     SendStart(myArray[3].process, myArray[3].lotid);
  //   } else if (process == "Freeze") {
  //     startTimeFreeze = millis();
  //     timerStartedFreeze = true;
  //     myArray[4] = { action, process, lotid, startTimeFreeze };
  //     SendRecieve(myArray[4].process, myArray[4].lotid);
  //     SendStart(myArray[4].process, myArray[4].lotid);
  //   } else if (process == "Pack") {
  //     startTimePack = millis();
  //     timerStartedPack = true;
  //     myArray[5] = { action, process, lotid, startTimePack };
  //     SendRecieve(myArray[5].process, myArray[5].lotid);
  //     SendStart(myArray[5].process, myArray[5].lotid);
  //   }
  // }
  if (action == "Run") {
    startTime[processNum] = millis();
    timerStarted[processNum] = true;
    myArray[processNum] = { action, process, lotid, startTime[processNum] };
    SendRecieve(myArray[processNum].process, myArray[processNum].lotid);
    SendStart(myArray[processNum].process, myArray[processNum].lotid);
  }

  else if (action == "On") {
    //작동중이였다면 노란색 아니라면 초록색 켜기
    digitalWrite(LedRed[processNum], LOW);
    digitalWrite(LedGreen[processNum], HIGH);
    digitalWrite(LedYellow[processNum], LOW);
    SendContinue(process, lotid);

  } else if (action == "Off") {
    digitalWrite(LedRed[processNum], HIGH);
    digitalWrite(LedGreen[processNum], LOW);
    digitalWrite(LedYellow[processNum], LOW);
    SendStop(process, lotid);
  }
}
