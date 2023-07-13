const unsigned long interval = 5000;  // 5초


bool isProcessing = false;               // 공정 시작 여부
unsigned long startTime = 0;  // 현재 process 중인 Job 처리 시작시간.
const unsigned long DURATION = 10000;   // 5초. 하나의 Job 이 처리되는 시간


void loop_process(){
 if(!isProcessing){
        // processing 중이 아니었다면
        startTime = millis(); // 새로 시작하는 Job 의 시작시간 기록
        isProcessing = true;
    }


}