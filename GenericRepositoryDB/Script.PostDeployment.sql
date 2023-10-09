if not exists (select 1 from Student)
begin
	insert into dbo.[Student] (FullName, Gender, Age, Address)
    values ('Johns', 0, 35, 'Melin St. 24'),
	('Sue', 1, 22, 'NewYork St. 1024'),
	('Mary', 1, 27, 'CA St. 220'),
	('Smith', 0, 45, 'Melin St. 15');
end