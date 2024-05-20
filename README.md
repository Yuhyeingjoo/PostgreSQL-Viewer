# Postgres Viewer

이 프로젝트는 C# Windows Forms 애플리케이션으로, PostgreSQL 데이터베이스에 연결하여 사용자가 입력한 SQL 쿼리를 실행하고 결과를 표시하는 프로그램입니다.


![image](https://github.com/Yuhyeingjoo/Postgres-/assets/54518241/4608ee0f-2e8a-4aea-ab9b-ed8d3c5d9346)


## 기능 및 사용 방법

1. 데이터베이스 연결 설정

- 애플리케이션을 실행하면 데이터베이스 연결 설정을 위한 화면이 표시됩니다.
사용자는 호스트, 데이터베이스 이름, 사용자 이름, 암호를 입력하여 PostgreSQL 데이터베이스에 연결합니다.
- Connect 버튼을 클릭하면 데이터베이스에 연결하며 해당 DB의 모든 테이블을 하단 표에 표시합니다.

2. SQL 쿼리 입력

- 데이터베이스에 연결한 후, 사용자는 SQL 쿼리를 입력할 수 있는 텍스트 상자를 제공받습니다.
- 사용자는 원하는 SQL 쿼리를 입력하고 Run 버튼을 클릭합니다.

3. 쿼리 실행 및 결과 표시:

- 입력한 SQL 쿼리가 실행되고, 그 결과가 표에 표시됩니다.
- 쿼리 결과를 편리하게 확인할 수 있습니다.


![image](https://github.com/Yuhyeingjoo/Postgres-/assets/54518241/bbcc36c2-8cee-466b-9313-f180fbd9fbee)

4. Tool -> Tabl List는 현재 연결된 데이터베이스의 모든 테이블을 표에 표시합니다.

5. Tool -> Export to csv는 현재 표에 있는 데이터 테이블을 csv 파일로 내보냅니다.





---


# 실행 예시
https://www.postgresqltutorial.com/wp-content/uploads/2019/05/dvdrental.zip

데이터베이스는 상기 PostgresSQL 공식 사이트에서 제공하는 샘플을 사용했습니다.



![image](https://github.com/Yuhyeingjoo/Postgres-/assets/54518241/7b4b7bd9-e5aa-494a-91a3-9b2c2755e00e)

1. Host, Postgres의 사용자 이름, Postgres의 비밀번호, 접속할 데이터베이스 이름을 입력한 후 Connect 버튼을 클릭하면 해당 데이터베이스에 접속하여 모든 테이블을 나열합니다.



![image](https://github.com/Yuhyeingjoo/Postgres-/assets/54518241/7f0a1a7b-d164-4084-bdb8-bdf6c82c1de0)

2. SQL 쿼리를 입력하고 Run 버튼을 클릭합니다. 실행 결과가 표에 표시됩니다.



![image](https://github.com/Yuhyeingjoo/Postgres-/assets/54518241/dd3acbfc-420a-4d50-80c6-61eeed99f4e2)
![image](https://github.com/Yuhyeingjoo/Postgres-/assets/54518241/6fe64cd4-0672-4b3a-8e79-f1a9b245ab4b)

3. Tool -> Export to csv 클릭하여 원하는 경로에 csv 파일을 생성합니다.


![image](https://github.com/Yuhyeingjoo/Postgres-/assets/54518241/f90962b9-830c-4bd7-aa71-11963c19ff8a)
![image](https://github.com/Yuhyeingjoo/Postgres-/assets/54518241/57f5bb4d-7e51-4f29-897a-f428cef326ce)

4. Tool -> Clear Viewer 를 선택하여 현재 표를 비웁니다.


![image](https://github.com/Yuhyeingjoo/Postgres-/assets/54518241/12579693-4065-46a6-b7c5-28d2bb2c3a3e)

5.  Tool -> Table list 를 선택하여 접속한 데이터베이스의 테이블 리스트를 표시합니다. 
