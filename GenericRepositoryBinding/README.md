# GenericRepositoryBinding

## 참고
[Generic Repository without Entity Framework using MS SQL & Dapper](https://youtu.be/a1Sbmv0qPpw?si=ZHxcAi_tQk-nyOrU)

## 설명:  디자인 패턴 적용 및 Input control에 DataBindings 사용
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