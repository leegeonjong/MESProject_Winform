void SendRecieve(String process, String lotid) {
  String sendData = String("");
  sendData += String("$Recieve")
              + "," + process + "," + lotid;
  Serial.println(sendData);
}

void SendStart(String process, String lotid) {
  String sendData = String("");
  sendData += String("$Start")
              + "," + process + ","
              + lotid;
  Serial.println(sendData);
}

void SendEnd(String process, String lotid) {
  String sendData = String("");
  sendData += String("$End")
              + "," + process + ","
              + lotid;
  Serial.println(sendData);
  Lot_Count = 0;
}

void SendContinue(String process, String lotid) {
  String sendData = String("");
  sendData += String("$Continue")
              + "," + process + "," + lotid;
  Serial.println(sendData);
}

void SendStop(String process, String lotid) {
  String sendData = String("");
  sendData += String("$Stop")
              + "," + process + "," + lotid;
  Serial.println(sendData);
}

void SendTestData(String process, String lotid, String data) {
  String sendData = String("");
  sendData += String("$Data")
              + "," + process + "," + lotid + "," + data;
  Serial.println(sendData);
}