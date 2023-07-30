void LCDSet(String arr[]){
     lcd.setCursor(0, 0);
     lcd.print("1: " + arr[0]); // 첫 번째 문자열 출력
     lcd.setCursor(6, 0);
     lcd.print("2: " + arr[1]); // 두 번째 문자열 출력
     lcd.setCursor(12, 0);
     lcd.print("3: " + arr[2]); // 세 번째 문자열 출력
     lcd.setCursor(0, 1);
     lcd.print("4: " + arr[3]); // 네 번째 문자열 출력
     lcd.setCursor(6, 1);
     lcd.print("5: " + arr[4]); // 다섯 번째 문자열 출력
     lcd.setCursor(12, 1);
     lcd.print("6: " + arr[5]); // 여섯 번째 문자열 출력
}

