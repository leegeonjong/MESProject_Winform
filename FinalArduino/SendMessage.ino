void SendRecieve(String process,String lotid) {
  String sendData = String("");
  sendData += String("$Recieve")
    +"," + process
    +"," + lotid
    ;
    Serial.println(sendData);
}

void SendStart(String process,String lotid) {
    String sendData = String("");
  sendData += String("$Start")
    +"," + process
    +"," + lotid
    ;
    Serial.println(sendData);
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