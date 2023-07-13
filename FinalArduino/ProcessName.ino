int ProcessName(String processName) {
  int processIndex = -1;  // 기본값으로 -1 설정

  if (processName == "Mix") {
    processIndex = 0;
  } else if (processName == "Shape") {
    processIndex = 1;
  } else if (processName == "Steam") {
    processIndex = 2;
  } else if (processName == "Fry") {
    processIndex = 3;
  } else if (processName == "Freeze") {
    processIndex = 4;
  } else if (processName == "Pack") {
    processIndex = 5;
  }

  return processIndex;
}
