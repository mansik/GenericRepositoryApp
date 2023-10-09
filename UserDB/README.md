# DB 프로젝트 생성 및 게시 방법

* SQL Server DataBase project 추가 
	* 프로젝트명 UserDB
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
	* 그러면 프로젝트에 UserDB.publish.xml파일로 존재
	* .GitIgnore를 통해 저장소에 빠지므로 마우스 우측클릭-> git ->`소스 제어에 무시된 파일 추가`를 통해 추가한다.
	* UserDB.publish.xml을 더블클릭하면 게시화면을 호출할 수 있으며,
	* 게시 한다.
	* Database가 제대로 생성 되었는지 확인한다.