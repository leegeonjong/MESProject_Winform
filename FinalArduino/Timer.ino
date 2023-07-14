void loop_process() {
  if (timerStarted && millis() - startTime >= timerDuration) {
    timerStarted = false;  // 타이머 상태 초기화
  }
  }