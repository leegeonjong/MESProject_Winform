#include <LiquidCrystal_I2C.h>
LiquidCrystal_I2C lcd(0x27, 16, 2);
String process, rest,action, lotid;  // command 와 나머지
void setup() {
  Serial.begin(9600);

  lcd.init();  // initialize the lcd
  lcd.backlight();
}

void loop() {
  action = ""; //공정상태
  rest = "";    //나머지
  process= "";   // 공정명
  lotid = "";   // lotid
  // $Run,Mix,213 명령 받고 이렇게 돌려주도록 한다
  
  if (Serial.available() > 0) {  // <- 수신 버퍼를 비우려면 while(Serial.available()) 사용해야 한다.  https://www.baldengineer.com/when-do-you-use-the-arduinos-to-use-serial-flush.html
    String line = Serial.readStringUntil('\n');
    line.trim();  // trim() 은 void 리턴.
    if (line.startsWith("$")) {
      action = line.substring(1, line.indexOf(",")); 
      rest = line.substring(line.indexOf(",") + 1);
      process = rest.substring(0, line.indexOf(",")); 
      lotid = rest.substring(line.indexOf(",") + 0);
      if (action == "Run") {
        lcd.print("run");
        Serial.println("$Recieve,lotstatus,lotid");
        Serial.println(action);
        Serial.println(process);
        Serial.println(lotid);

      }
    }
  }
}
