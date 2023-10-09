# Generic Repository without Entity Framework using MS SQL & Dapper

# ������Ʈ

# GenericRepository 

## ����
[Generic Repository without Entity Framework using MS SQL & Dapper](https://youtu.be/a1Sbmv0qPpw?si=ZHxcAi_tQk-nyOrU)

## ����:  ������ ���� ����
��ȸ�� 829ȸ  2023. 4. 24.
Brief tutorial on creating a generic repository for common crud task.
This tutorial does not uses Entity Framework instead it is using Dapper and raw SQL queries.

## ȯ��
* Visual Studio: [ ] 2019, [x] 2022
* ������Ʈ ����: [ ] .Net Framework, [x] .Net WinForm(windows form)
* Package 
  * [ ] DevExpress 18.2
* NuGet
  * [x] System.Data.SqlClient
  * [x] Dapper 

## �۾�
* DataGridView���� ������ ���� ���� -> ������ ���� �����̸� Student�� �����ϸ� DataGridView�� �÷��� ��Ÿ����.
* studentIDTextEDit, fullNameTextEDit, ageTextBox,  addressTextBox �� ��Ʈ���� �Ӽ� 
* -> DataBindings-> Text�� studentBindingSource�� �� �÷����� �����Ѵ�.
* genderCheckBox ��Ʈ���� �Ӽ� -> DataBindings-> Checked�� studentBindingSource�� Gender�÷����� �����Ѵ�.
* Form_Load()�� dataGridView.AutoGenerateColumns = false; �߰�
    ```
    [dataGridView �÷� �ߺ� �߰� ����]
    DataGridView.AutoGenerateColumns�� �⺻���� true�̴�.
    �׷��Ƿ�, Form �����̳ʿ��� �÷��� �߰��� ��
    1. DataSource ������ ��Ÿ�ӿ��� �ϸ� �⺻���� true�̹Ƿ� �ڵ����� �÷��� �߰��ȴ�. 
       => �̸� �����ϱ� ���ؼ� false�� �ٲ��ش�.
    2. DataSource ������ Form �����̳ʿ��� �ϸ� AutoGenerateColumns = false;�� �ڵ����� �ǹǷ� �ʿ����.
               dataGridView.AutoGenerateColumns = false; 
    ```
# GenericRepositoryBinding : ������ ���� ���� �� Input control�� DataBindings ���

# GenericRepositoryDB : DB ���� ������Ʈ

## DB ������Ʈ ���� �� �Խ� ���
* SQL Server DataBase project �߰� 
	* ������Ʈ�� GenericRepositoryDB
	* dbo ���� �߰�
		* Tables ���� �߰�
			* `Table` �߰�
			* Student
	* StoredProcedures ���� �߰�
		* `���� ���ν���` �߰�
		* spUser_GetAll
		* spUser_GetById
		* spUser_Insert
		* spUser_Update
		* spUser_Delete
	* DataBase project���� `��ũ��Ʈ` �߰�
		* `���� �� ��ũ��Ʈ` �߰� => Script.PostDEployment.sql
		* ���̺� ������ ���� �ۼ�
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
	* DataBase project���� `�Խ�` ����
		* �������� DB �ν��Ͻ� ����
		* Database �̸� GenericRepository
		* ��ũ��Ʈ �̸� UserDB.sql => �ڵ����� ������
		* Profile�� ����
	* �׷��� ������Ʈ�� GenericRepositoryDB.publish.xml���Ϸ� ����
	* .GitIgnore�� ���� ����ҿ� �����Ƿ� ���콺 ����Ŭ��-> git ->`�ҽ� ��� ���õ� ���� �߰�`�� ���� �߰��Ѵ�.
	* GenericRepositoryDB.publish.xml�� ����Ŭ���ϸ� �Խ�ȭ���� ȣ���� �� ������,
	* �Խ� �Ѵ�.
	* Database�� ����� ���� �Ǿ����� Ȯ���Ѵ�.