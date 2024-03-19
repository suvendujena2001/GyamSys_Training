SELECT TOP (1000) [EmpId]
      ,[FName]
      ,[LName]
      ,[Email]
      ,[Salary]
  FROM [AdventureWorks2022].[dbo].[Employee]

  
  select * from Employee;
 EXEC sp_rename 'dbo.ErrorLog.ErrorTime', 'ErrorDateTime', 'COLUMN';
 alter table Employee rename column FirstName to FName;


 alter table Employee
 add DeptId integer;
 
 update  Employee
 set DeptId = 4
 where EmpId = 5;




 --rename a column name in sql
exec sp_rename 'Employee.LName' , 'LastName';
exec sp_rename 'Employee.[Employee.FirstName]','FirstName';

select * from Employee;

select * from Department;

--left join
select  emp.EmpId ,emp.FirstName, dept.DeptId,dept.Name
from Employee emp
left join Department dept
on emp.DeptId = dept.DeptId;


--right join
select  emp.EmpId ,emp.FirstName, dept.DeptId,dept.Name
from Employee emp
right join Department dept
on emp.DeptId = dept.DeptId;


--full join
select  emp.EmpId ,emp.FirstName, dept.DeptId,dept.Name
from Employee emp
full join Department dept
on emp.DeptId = dept.DeptId;


--operators in sql server
select EmpId , FirstName , LastName ,Salary 
from Employee
where Salary between 18000 and 20000;


select EmpId , FirstName , LastName , Salary 
from Employee 
where EmpId in (1,2,3,4);

select * from Employee 
where DeptId in (select DeptId from Department where DeptId >= 2);


select * from Employee
where FirstName like 'suvam';

select * from Employee
where FirstName like 's%';

select * from Employee
where FirstName like '%a%';

select * from Employee
where FirstName like '_u___';

select * from Employee
where FirstName like 'S[u,v,a,x]%';

select * into Emp from Employee;
select * from Emp;
update Emp
set LastName ='k'
where EmpId = 6;

select * from Employee;
select * from Emp;

insert into emp(EmpId,FirstName,LastName,Email,Salary,DeptId)
values(5,'Lex','Patel','Amit@test.com', 19500,4);


select * from Employee
union all
select * from Emp;

select distinct FirstName from Emp;



