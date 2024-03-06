
USE [master]

GO
 
/****** Object:  Table [dbo].[EMPLOYEE]    Script Date: 28-02-2024 14:48:34 ******/

SET ANSI_NULLS ON

GO
 
SET QUOTED_IDENTIFIER ON

GO
 
CREATE TABLE [dbo].[EMPLOYEE](

	[EMPID] [int] NULL,

	[EMPNAME] [varchar](100) NULL,

	[EMPSALARY] [int] NULL,

	[EMPDEPTID] [int] NULL

) ON [PRIMARY]

GO

INSERT INTO EMPLOYEE VALUES(1,'ANAND',70000,1)

INSERT INTO EMPLOYEE VALUES(2,'MUKUND',80000,1);

insert into employee values(3,'RAJ',2000,5);

INSERT INTO EMPLOYEE VALUES(4,'ABHISHEK',70000,6)
 
INSERT INTO EMPLOYEE VALUES(5,'AYUSH',60000,2),(6,'MUKUND',21500,3);
 
INSERT INTO EMPLOYEE VALUES(7,'VENU',80000,2),(8,'Adi',35000,4),(9, 'Aditya', 50000, 6),(10,'Spardha',21545,7);

select * from employee ;

create table dept(deptid int,deptname varchar(100));

insert into dept values(1,'MICROSOFT'),(2,'SAP'),(3,'SALESFORCE'),(4,'DA');

update EMPLOYEE set EMPDEPTID=3 where EMPDEPTID=5;
update EMPLOYEE set EMPDEPTID=4 where EMPDEPTID=6;
update EMPLOYEE set EMPDEPTID=1 where EMPDEPTID=7;


select * from dept;

select * from EMPLOYEE select * from dept;

select emp.empid,emp.empname,emp.empsalary,emp.EMPDEPTID,dept.deptname from employee emp inner join dept on emp.EMPDEPTID=dept.deptid;

select * from employee where empname like '%d%';
select * from employee where EmpSalary BETWEEN 30000 AND 70000
select * from employee WHERE EmpName like '%a'
select * from employee WHERE EmpName not like '%a%'
select * from employee WHERE EmpId IN (1,3,6,9);

--select * from empSource intersect select * from empTarget

if 3000>= some(select EMPSALARY from employee) print('greater than 3000')
else print('less than 3000');

SELECT * FROM Employee 
WHERE EmpId = 1 AND EmpId = 3;

SELECT * FROM Employee 
WHERE EmpId != 1 AND EmpId != 2 AND EmpId != 3 AND EmpId != 4; 

SELECT * FROM Employee 
WHERE EmpId != ALL(
                    SELECT EmpId FROM dept 
            );

-- AVG
select empdeptid as department_id, avg(empsalary) as average_salary from employee group by EMPDEPTID;

-- COUNT
SELECT EMPDEPTID, COUNT(EMPID) AS Total_Employees 
FROM Employee
GROUP BY empDeptId;

-- MAX
select empdeptid, max(empsalary) as max_salary from EMPLOYEE group by empdeptid;

--MIN
select empdeptid, min(empsalary) as min_salary from EMPLOYEE group by empdeptid;

--SUM
select empdeptid, sum(empsalary) as total_salary from EMPLOYEE group by empdeptid;
