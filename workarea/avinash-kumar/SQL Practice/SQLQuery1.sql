use AdventureWorks2022;
go
exec sp_rename 'HumanResources.hr_dep','HumanResourses.Department';


select * from HumanResources.[HumanResourses.Department];

