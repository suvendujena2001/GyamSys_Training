select * from Department;
select * from Employee1;
--OPERATORS
--1_BETWEEN
select empid,empname,empsalary from Employee1 where empsalary between 20000 AND 50000;
--2 IN
select empdeptid,empid,empname from Employee1 where empdeptid in(1);
select empdeptid,empid from Employee1 where empid in (select deptId from Department where deptId >0);
--3 LIKE
select * from Employee1 where   empname like 'adi';
select * from Employee1 where  empname like 'a%i';
--4 Intersect
select * From Employee1 intersect select * from Department;  --having equal number of rows(condition).
--5 MINUS
select * From Employee1 MINUS select * from Department; 
--6 UNION
select * From Employee1 UNION select * from Department; --having equal number of rows(condition), remove duplicates.
--7 UNION ALL
select * From Employee1 UNION ALL select * from Department; --having equal number of rows(condition),  do not remove duplicates.
--8 DISTINCT
select distinct empname from Employee1; 
select count(distinct deptid) from Department;
--9 ANY,SOME
select * from Employee1 where empdeptid=ANY(select deptId from Department where deptId=1);




