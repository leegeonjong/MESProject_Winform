
# **라면 공장 스마트팩토리 MES 프로그램**

## **팀명: 라면인건가**

### **팀원 및 역활 분담**
- 팀장: 이건종 - LOT CRUD, 하드웨어, SERIAL 통신
- 팀원: 김택수 - 검사, 하드웨어 
- 팀원: 김동후 - 재고관리, 현향표
- 팀원: 김혁주 - 웹


## **개요**
- 소프트웨어, 하드웨어 , 데이터베이스간 실시간 데이터 연동과 Serial 통신이 가능한 MES 시스템



## **개발 환경 및 활용 기술**
C#, ASP.NET, Winform, Arduino, Entity FrameWork

## **공헌한 내용**
- 기여도 40%
- LOT CRUD
- LOT 상태의 따른 공정 실행 결과 판단
- 현재 LOT상태의 대한 조회가능
- 공정을 통과한 LOT 이력 조회기능 구현
- Serial Protocol 설계
- H/W 와 S/W 간의 양방향 Serial 통신 구현
- 공정별 기능 구현
- 공정별 타이머 기능
- LCD, LED를 통한 하드웨어 동작
- 온습도센서, 초음파센서, 수심 측정 센서, LED, 버튼 제어
- 공정이 시작되면 10초 타이머 실행, 공정이 멈추면 타이머 일시정지 기능 구현
- 프로토콜의 따른 메인페이지



[제작 시연 영상]


## **프로젝트 설명**

### **공정 구현에 사용된 입출력 장치**

|부품명|사용 개수|사용 목적|
|---|---|---
|DHT11 온습도센서|1| 스팀기의 온도 검사
|Water Level Sensor|1|팜유의 용량 검사
|HC-SR04 초음파 센서|2|입출고시 LOT 개수 검사
|I2C LCD|1|공정 현황 실시간 표시
|LED_RED 빨간색|6|공정 정지시 점등
|LED_GREEN 초록색|6|공정 대기시 점등
|LED_YELLOW 노란색|6|공정 진행시 점등

### **시스템 구성도**

![시스템 구성도](./image/image1.png)

### **프로토콜**

![프로토콜](./image/image2.png)


### **공정 구성도**

![공정 구성도](./image/image3.png)

### **LOT 생성**

![LOT 생성](./image/image4.png)

### **프로토콜 EX**

![프로토콜 EX](./image/image5.png)

### **공정 진행**

![공정 진행](./image/image6.png)


[제작 시연 영상]: https://www.youtube.com/watch?v=EIa28L82daU&list=PLedGoSru794-VINQHqtNmjeTm0uuZJ1Ck&index=1&ab_channel=MasterCode
