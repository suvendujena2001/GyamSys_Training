select * from Department;
select * from Employee1;
-- FUNCTIONS
--1_ AVERAGE
select  empdeptid,AVG(empsalary) As' Average Salary 'from Employee1 group by empdeptid;
--2_ COUNT
select  empdeptid ,count(*) as 'total count' from Employee1 group by empdeptid;
select count(distinct empdeptid) from Employee1;
--3_ MAX
Select * from Employee1 where empsalary= (select MAX(empsalary) from Employee1);
--4_ MIN
Select * from Employee1 where empsalary= (select MIN(empsalary) from Employee1);
select MAX(empname) from Employee1;
--5_ SUM
select empdeptid,SUM(empsalary) as 'total' from Employee1 group by empdeptid;

