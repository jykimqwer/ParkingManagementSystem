# ParkingManagementSystem

# 🚗 프로젝트 요약

 ### Project name: 2-Way 입출구 분리형 무인 주차 관리 시스템   
 ### Project goal: 차량 번호판 인식 모델을 통한 주차 관리 시스템 개발하여 주차장을 무인으로 관리할 수 있게 한다.   
   
<div align="center"><img src="https://img.shields.io/badge/Tag: -000000?style=plastic&logo=Tag&logoColor=white"> <img src="https://img.shields.io/badge/Python-3776AB?style=plastic&logo=Python&logoColor=white"><img src="https://img.shields.io/badge/Visual Studio Code-007ACC?style=plastic&logo=visualstudiocode&logoColor=white"><img src="https://img.shields.io/badge/Csharp-512BD4?style=plastic&logo=csharp&logoColor=white"><img src="https://img.shields.io/badge/STM32-03234B?style=plastic&logo=stmicroelectronics&logoColor=white"><img src="https://img.shields.io/badge/Pytorch-EE4C2C?style=plastic&logo=pytorch&logoColor=white">   
 
 <img src="https://img.shields.io/badge/OpenCV-5C3EE8?style=plastic&logo=opencv&logoColor=white"><img src="https://img.shields.io/badge/MySQL-4479A1?style=plastic&logo=mysql&logoColor=white"><img src="https://img.shields.io/badge/.NET-512BD4?style=plastic&logo=.NET&logoColor=white"><img src="https://img.shields.io/badge/Notion-000000?style=plastic&logo=Notion&logoColor=white"> <img src="https://img.shields.io/badge/NuGet-004880?style=plastic&logo=NuGet&logoColor=white"><img src="https://img.shields.io/badge/Arm Keil-394049?style=plastic&logo=armKEIL&logoColor=white"> </div>

# 시연영상

[![Video Label](http://img.youtube.com/vi/g3SmT2Eb09A/0.jpg)](https://youtu.be/g3SmT2Eb09A)

## 구현화면(관리자 화면)


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
  * YOLO5 학습 모델을 이용하여 화상 카메라를 통한 차량 번호판 인식
  * UART 통신을 수신하여 차단기(서보모터) 제어
  * 데이터베이스 서버 공유

 ### Out of Scope:
   * YOLO5 모델 최적화
   * 다양한 번호판 인식
   * 라즈베리파이에 구현
   * LCD 구현

 ### Kanban


 ### Gantt


 # 📖 회의
1차 프로젝트 회의 2024-02-20 참석자: 김다린, 김준영
| 안건 | 결정사항 |
|:--:|:--:|
|프로젝트 계획| 프로젝트 방향성 고정 |
|시스템 구성 결정|Python, C#, MySQL, STM32, 라즈베리파이, 서보모터 사용|
|역할 분담| Python: 김다린, C#: 김준영|
|형상 관리 Tool 결정 | 공유 Notion 및 GitHub 사용|
***
2차 프로젝트 회의 2024-02-22 참석자: 김다린, 김준영
| 안건 | 결정사항 |
|:--:|:--:|
|시스템 구성 변경|* DB 구성 변경<br> * 소켓통신 데이터 처리|
|사용 H/W를 변경|라즈베리파이-> Python 직접 진행|
|진행사항 리뷰|* 번호판 인식,<br> * MySQL 연동 완료<br>  * 주차 요금 정산 구성완료|
***
3차 프로젝트 회의 2024-02-24 참석자: 김다린, 김준영
| 안건 | 결정사항 |
|:--:|:--:|
|진행 사항 확인|* 프로그램 간 소켓통신 완료 <br>      * 시리얼통신으로 서보모터 구동 완료 <br>* 정산 프로그램 데이터처리 Bug Fix 완료|
|최종 테스트 일정 확인|2/26 테스트 및 Bug Fix|
|보고서 작성|최종 테스트 바탕으로 최종 보고서 작성 및 리뷰 일정 Fix|
***
추가 프로젝트 회의 2024-02-27 참석자: 김다린, 김준영
| 안건 | 결정사항 |
|:--:|:--:|
|Backlog 구현|사전정산 추가, 관리자 모드 추가 구현|
|테스트|최종 구현된 프로그램 테스트 및 리뷰 일정 Fix|

# ✔프로젝트 일지
### 2024-02-20
* 모든 팀원   
    1. 차량 및 번호판 탐지(이미지 파일 이용)
    2. 번호판 이미지 텍스트로 변환(이미지 파일 이용)

### 2024-02-21
* 김다린   
    1. 차량 및 번호판 탐지(웹캠 이용)
    2. 번호판 이미지 텍스트로 변환(웹캠 이용)
    3. 서보모터 구동
* 김준영
    1. GUI(C#)   
        1. 관리자 로그인(DB 로그인)
        2. 관리자 전용 페이지 구현
        3. 정산 화면 구현
    2. MySQL 연동

### 2024-02-22
* 김다린
    1. 영상에 번호판 감지 시 캡쳐하여 사진 저장
    2. 번호판 감지 시간 간격 설정
    3. 하드웨어 구현(주차장 및 차단기)
* 김준영
    1. 프로젝트 구성도 수정
    2. DB 버그 수정
    3. C# 수정
        1. 일/월/년별 조회
        2. 정산 시 데이터 처리 수정
### 2024-02-23
* 김다린
    1. 서보모터 2개 동시 구동
    2. 파이썬 - STM 시리얼 통신 구현
* 김준영
    1. 관리자 모드 기간 조회 기능 구현
    2. 정산 시 요금 계산 방식 변경

### 2024-02-24
* 김준영
    1. C# 버그 수정
    2. 파이썬-C# 소켓 통신 구현

### 2024-02-26
* 김다린
    1. 시리얼 통신으로 서보모터 & 초음파센서 구동
* 김준영
    1. 데이터베이스 수정(Python과 C#에서 사용하는 데이터베이스로 분리) 
* 공통
    1. 테스트 및 버그 픽스
### 2024-02-27
* 공통
    1. 발표 자료 작성 및 리뷰
### 2024-02-28
* 김다린
    1. STM 1대 추가 구현.
    2. 하드웨어 추가 구현(STM 추가)
* 김준영
    1. 사전정산, 관리자 프로그램 구현
    2. 사전정산, 기존 정산프로그램과 연동
### 2024-02-29
* 공통
    1. Backlog 구현 테스트 및 Bug Fix
    2. 프로젝트 종료

# Issue Management
| 이슈사항 | 해결방안 | 주요코드 |
|--|--|--|
|파이썬, c# <br>소켓통신 충돌| 새로운 포트를 열어 소켓통신마다<br> 각각 포트를 부여함 | - |
|출차 시 정산 관련 데이터를<br> 실시간으로 받지 못함| 비동기 호출을 사용해<br> 데이터를 보낼 때만 데이터를 수신 | |
|MySQL로 데이터 전송 시 <br>전송 방식 관련 오류| MySQL 테이블 복제 후<br> MySQL 서버 재구축 | |
|입출차 시 번호판 감지가 제대로 되었으나,<br> MySQL 서버에 정확한 데이터가 전송되지 않음| 입출차 함수 실행 시 <br>쓰레드를 사용해 구동 | |





