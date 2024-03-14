# ParkingManagementSystem

# 🚗 프로젝트 요약

 ### Project name: 무인 주차 관리 시스템   
 ### Project goal: 차량 번호판 인식 모델을 통한 주차 관리 시스템 개발하여 주차장을 무인으로 관리할 수 있게 한다.   
   
<div align="center"><img src="https://img.shields.io/badge/Tag: -000000?style=plastic&logo=Tag&logoColor=white"> <img src="https://img.shields.io/badge/Python-3776AB?style=plastic&logo=Python&logoColor=white"><img src="https://img.shields.io/badge/Visual Studio Code-007ACC?style=plastic&logo=visualstudiocode&logoColor=white"><img src="https://img.shields.io/badge/Csharp-512BD4?style=plastic&logo=csharp&logoColor=white"><img src="https://img.shields.io/badge/STM32-03234B?style=plastic&logo=stmicroelectronics&logoColor=white"><img src="https://img.shields.io/badge/Pytorch-EE4C2C?style=plastic&logo=pytorch&logoColor=white">   
 
 <img src="https://img.shields.io/badge/OpenCV-5C3EE8?style=plastic&logo=opencv&logoColor=white"><img src="https://img.shields.io/badge/MySQL-4479A1?style=plastic&logo=mysql&logoColor=white"><img src="https://img.shields.io/badge/.NET-512BD4?style=plastic&logo=.NET&logoColor=white"><img src="https://img.shields.io/badge/Notion-000000?style=plastic&logo=Notion&logoColor=white"> <img src="https://img.shields.io/badge/NuGet-004880?style=plastic&logo=NuGet&logoColor=white"><img src="https://img.shields.io/badge/Arm Keil-394049?style=plastic&logo=armKEIL&logoColor=white"> </div>

### **팀 구성**
| 이름 | 메인 업무 |
|:--:|:--:|
|김다린|영상 처리, 통신 및 모터 제어 시스템 구현|
|김준영|데이터베이스(My SQL), 데이터 처리, 통신 및 모터 제어 시스템 구현|   
   
### Objectives:
 **무인 관리로 효율성 향상**: 사람이 상주하지 않아도 무인 정산 키오스크를 사용하여 정산과 관리를 더 효율적으로 할 수 있습니다.   

### Constraints:
 * 프로젝트를 완료하는 데 할당된 시간이 제한되어 있습니다.   
 * 하드웨어 사양에 따른 구동환경 제어와 최적화 과정에서 높은 난이도가 요구되었습니다.   

### Assumptions:   
 * Python을 사용함에 따라 C/C++ 언어 사용 대비 상대적 딜레이가 발생할 수 있습니다.   

 # 📆 프로젝트 범위 및 계획   
 ### In Scope:
  * YOLO5 학습 모델을 이용하여 어쩌구 카메라를 통한 차량 번호판 인식
  * UART 통신을 수신하여 차단기(서보모터) 제어
  * 데이터베이스 서버 공유

 ### Out of Scope:
   * YOLO5 모델 최적화
   * 다양한 번호판 인식
   * 라즈베리파이에 구현
   * LCD 구현

 ### Kanban


 # 📖 회의
1차 프로젝트 계획 회의 |2024-02-20| 참석자: 김다린, 김준영
| 안건 | 내용 | 결정사항 |
|:--:|:--:|:--:|
|프로젝트 일정 조정| 계획 및 일정 확인 | 프로젝트 방향성 고정 |
|시스템 구성|사용 S/W, H/W 결정|Python, C#, MySQL, STM32, 라즈베리파이, 서보모터 사용|
|역할 분담| 팀원의 역할 재확인 | Python: 김다린, C#: 김준영|
|기타 사항| 형상 관리 Tool 결정 | 공유 Notion 및 GitHub 사용|
***
2차 프로젝트 계획 회의 |2024-02-23| 참석자: 김다린, 김준영
| 안건 | 내용 | 결정사항 |
|:--:|:--:|:--:|
|시스템 구성|시스템 구성 변경|DB 중심 구성-> DB(데이터 저장 용도로만 사용)구성 변경   소켓통신 데이터 처리|
|         |시스템 구성 추가|사전정산 추가, 관리자 모드 추가|
|사용 기술|사용 H/W를 변경|라즈베리파이-> Python 직접 진행|
|진행 사항 확인| 진행사항 리뷰|번호판 인식, MySQL 연동   주차 요금 정산 구성완료|
***
3차 프로젝트 계획 회의 |2024-02-26| 참석자: 김다린, 김준영
| 안건 | 내용 | 결정사항 |
|:--:|:--:|:--:|
|진행 사항 확인| 진행사항 리뷰|프로그램 간 소켓통신 완료  시리얼통신으로 서보모터 구동  사전정산과 정산 프로그램 연동완료|
|일정|테스트 일정 확인|2/28 테스트 및 Bug Fix|
***
