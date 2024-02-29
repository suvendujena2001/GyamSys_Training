CREATE TABLE [dbo].[EMPLOYEE](
[EMPID] [int] NULL,
[EMPNAME] [varchar](100) NULL,
[EMPSALARY] [int] NULL,
[EMPDEPTID] [int] NULL)

insert into employee values(1,'Ashrita', 160000,2);
INSERT INTO EMPLOYEE VALUES(2,'MUKUND',80000,1);
insert into employee values(3,'RAJ',2000,5);
INSERT INTO EMPLOYEE VALUES(4,'ABHISHEK',70000,6);
 INSERT INTO EMPLOYEE VALUES(5,'AYUSH',60000,2);
 INSERT INTO EMPLOYEE VALUES(6,'VENU',80000,2),(7,'Adi',35000,4),(8, 'Aditya', 50000, 6),(9,'Spardha',21545,7);


 CREATE TABLE DEPT(DeptId INT,DeptName VARCHAR(100))
INSERT INTO Dept(DeptId,DeptName) VALUES(1,'MICROSOFT'),
(2,'SAP'),
(3,'SALESFORCE'),
(4,'DA');
SELECT dept.DeptId, dept.deptName, employee.empid, employee.empName  
FROM Employee
RIGHT JOIN  dept
ON employee.empid = dept.DeptId;


SELECT employee.empid, employee.empName, dept.DeptId, dept.deptName 
FROM Employee 
LEFT JOIN  dept
ON employee.empId = dept.DeptId;


SELECT Employee.EmpId, Employee.empName, Employee.empsalary, dept.deptid
FROM Employee 
INNER JOIN Dept
ON Employee.empId = Dept.DeptId;

SELECT employee.EmpId, employee.empName, dept.DeptId, dept.deptName 
FROM Employee 
FULL JOIN  dept
ON employee.empId = dept.DeptId;