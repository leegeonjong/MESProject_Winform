void SendRecieve(String Process,) {
  String sendData = String("")
  sendData += String()
}

void SendStart() {
}

void SendEnd() {
}

void SendOff(String process) {
  String sendData = String("");
  sendData += String("$Off") + "," + process;
  Serial.println(sendData);
}

void SendOn(String process) {
  String sendData = String("");
  sendData += String("$On") + "," + process;
  Serial.println(sendData);
}