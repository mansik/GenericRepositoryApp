# Generic Repository without Entity Framework using MS SQL & Dapper

# 프로젝트

# GenericRepository 

## 참고
[Generic Repository without Entity Framework using MS SQL & Dapper](https://youtu.be/a1Sbmv0qPpw?si=ZHxcAi_tQk-nyOrU)

## 설명:  디자인 패턴 적용
조회수 829회  2023. 4. 24.
Brief tutorial on creating a generic repository for common crud task.
This tutorial does not uses Entity Framework instead it is using Dapper and raw SQL queries.

## 환경
* Visual Studio: [ ] 2019, [x] 2022
* 프로젝트 생성: [ ] .Net Framework, [x] .Net WinForm(windows form)
* Package 
  * [ ] DevExpress 18.2
* NuGet
  * [x] System.Data.SqlClient
  * [x] Dapper 

## 작업
* DataGridView에서 데이터 원본 선택 -> 데이터 원본 형식이름 Student를 선택하면 DataGridView의 컬럼이 나타난다.
* studentIDTextEDit, fullNameTextEDit, ageTextBox,  addressTextBox 의 컨트롤의 속성 
* -> DataBindings-> Text를 studentBindingSource의 각 컬럼명을 선택한다.
* genderCheckBox 컨트롤의 속성 -> DataBindings-> Checked를 studentBindingSource의 Gender컬럼으로 선택한다.
* Form_Load()에 dataGridView.AutoGenerateColumns = false; 추가
    ```
    [dataGridView 컬럼 중복 추가 방지]
    DataGridView.AutoGenerateColumns의 기본값이 true이다.
    그러므로, Form 디자이너에서 컬럼을 추가한 후
    1. DataSource 셋팅을 런타임에서 하면 기본값이 true이므로 자동으로 컬럼이 추가된다. 
       => 이를 방지하기 위해서 false로 바꿔준다.
    2. DataSource 셋팅을 Form 디자이너에서 하면 AutoGenerateColumns = false;로 자동으로 되므로 필요없다.
               dataGridView.AutoGenerateColumns = false; 
    ```
# GenericRepositoryBinding : 디자인 패턴 적용 및 Input control에 DataBindings 사용

# GenericRepositoryDB : DB 생성 프로젝트

## DB 프로젝트 생성 및 게시 방법
* SQL Server DataBase project 추가 
	* 프로젝트명 GenericRepositoryDB
	* dbo 폴더 추가
		* Tables 폴더 추가
			* `Table` 추가
			* Student
	* StoredProcedures 폴더 추가
		* `저장 프로시저` 추가
		* spUser_GetAll
		* spUser_GetById
		* spUser_Insert
		* spUser_Update
		* spUser_Delete
	* DataBase project에서 `스크립트` 추가
		* `배포 후 스크립트` 추가 => Script.PostDEployment.sql
		* 테이블에 삽입할 쿼리 작성
		```SQL
		if not exists (select 1 from Student)
		begin
			insert into dbo.[Student] (FullName, Gender, Age, Address)
			values ('Johns', 0, 35, 'Melin St. 24'),
			('Sue', 1, 22, 'NewYork St. 1024'),
			('Mary', 1, 27, 'CA St. 220'),
			('Smith', 0, 45, 'Melin St. 15');
		end
		```
	* DataBase project에서 `게시` 선택
		* 편집에서 DB 인스턴스 선택
		* Database 이름 GenericRepository
		* 스크립트 이름 UserDB.sql => 자동으로 생성됨
		* Profile로 저장
	* 그러면 프로젝트에 GenericRepositoryDB.publish.xml파일로 존재
	* .GitIgnore를 통해 저장소에 빠지므로 마우스 우측클릭-> git ->`소스 제어에 무시된 파일 추가`를 통해 추가한다.
	* GenericRepositoryDB.publish.xml을 더블클릭하면 게시화면을 호출할 수 있으며,
	* 게시 한다.
	* Database가 제대로 생성 되었는지 확인한다.