void SendRecieve(String process, String lotid) {
  String sendData = String("");
  sendData += String("$Recieve") + "," + process + "," + lotid;
  Serial.println(sendData);
}

void SendStart(String process, String lotid) {
  String sendData = String("");
  sendData += String("$Start") + "," + process + "," + lotid;
  Serial.println(sendData);
}

void SendEnd(String process, String lotid) {
  String sendData = String("");
  sendData += String("$End") + "," + process + "," + lotid;
  Serial.println(sendData);
}

void SendOff(String process, String lotid) {
  String sendData = String("");
  sendData += String("$Off") + "," + process + "," + lotid;
  Serial.println(sendData);
}

void SendOn(String process, String lotid) {
  String sendData = String("");
  sendData += String("$On") + "," + process + "," + lotid;
  Serial.println(sendData);
}