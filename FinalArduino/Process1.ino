bool toggleStatus;

void Process1(int Process1Led1, int Process1Led2, int Process1Motor, int Process1Sw) {
  int switchState = digitalRead(Process1Sw);

  if (switchState == LOW && toggleStatus == true) {
    digitalWrite(Process1Led1, HIGH);
    digitalWrite(Process1Led2, LOW);
    digitalWrite(Process1Motor, HIGH);
    toggleStatus = !toggleStatus;
    SendOn("Mix");
  }
  else if (switchState == LOW && toggleStatus == false) {
    digitalWrite(Process1Led1, LOW);
    digitalWrite(Process1Led2, HIGH);
    digitalWrite(Process1Motor, LOW);
    toggleStatus = !toggleStatus;
    SendOff("Mix");
  }
}