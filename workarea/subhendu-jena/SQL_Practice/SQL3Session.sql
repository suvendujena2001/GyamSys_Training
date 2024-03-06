--CREATE TABLE EMPLOYEE	(EmpId int, EmapName varchar(100),EmpSalary int, EmpDeptId int);
INSERT INTO EMPLOYEE VALUES(1,'Subhendu',30000,3);
INSERT INTO EMPLOYEE VALUES(2,'MUKUND',80000,1);
insert into EMPLOYEE values(3,'RAJ',2000,2);
INSERT INTO EMPLOYEE VALUES(4,'ABHISHEK',70000,3)
 
INSERT INTO EMPLOYEE VALUES(5,'AYUSH',60000,2),(6,'MUKUD',21500,3);
 
INSERT INTO EMPLOYEE VALUES(7,'VENU',80000,2),(8,'Adi',35000,4),(9, 'Aditya', 50000, 3),(10,'Spardha',21545,1);

UPDATE EMPLOYEE SET EmpDeptId=6 WHERE EmpId=8;

--CREATE TABLE DEPT(DeptID int, DeptName varchar (100));

SELECT * FROM DEPT;
SELECT * FROM EMPLOYEE;

INSERT INTO DEPT values(1,'MICROSOFT');
INSERT INTO DEPT values(2,'SAP');
INSERT INTO DEPT values(3,'SALESFORCE');
INSERT INTO DEPT values(4,'DA');

--EXEC sp_rename 'EMPLOYEE.EmapName','EmpName';

SELECT emp.EmpName, emp.EmpSalary, dep.DeptId, dep.DeptName FROM EMPLOYEE emp INNER JOIN DEPT dep ON emp.EmpDeptId=dep.DeptID;

SELECT emp.EmpName, emp.EmpSalary, dep.DeptId, dep.DeptName FROM EMPLOYEE emp LEFT JOIN DEPT dep ON emp.EmpDeptId=dep.DeptID;

SELECT emp.EmpName, emp.EmpSalary, dep.DeptId, dep.DeptName FROM EMPLOYEE emp RIGHT JOIN DEPT dep ON emp.EmpDeptId=dep.DeptID;

SELECT emp.EmpName, emp.EmpSalary, dep.DeptId, dep.DeptName FROM EMPLOYEE emp FULL JOIN DEPT dep ON emp.EmpDeptId=dep.DeptID;

SELECT * FROM EMPLOYEE WHERE EmpSalary BETWEEN 50000 and 67000;

SELECT * FROM EMPLOYEE WHERE EmpName LIKE '%u%';

SELECT * FROM EMPLOYEE WHERE EmpSalary IN(2000,35000,70000,50000);


SELECT emp.EmpName, emp.EmpSalary, dep.DeptId, dep.DeptName FROM EMPLOYEE emp LEFT JOIN DEPT dep ON emp.EmpDeptId=dep.DeptID
UNION
SELECT emp.EmpName, emp.EmpSalary, dep.DeptId, dep.DeptName FROM EMPLOYEE emp RIGHT JOIN DEPT dep ON emp.EmpDeptId=dep.DeptID ORDER BY DeptId;


SELECT emp.EmpName, emp.EmpSalary, dep.DeptId, dep.DeptName FROM EMPLOYEE emp LEFT JOIN DEPT dep ON emp.EmpDeptId=dep.DeptID
INTERSECT
SELECT emp.EmpName, emp.EmpSalary, dep.DeptId, dep.DeptName FROM EMPLOYEE emp RIGHT JOIN DEPT dep ON emp.EmpDeptId=dep.DeptID ORDER BY DeptID;

SELECT emp.EmpName, emp.EmpSalary, dep.DeptId, dep.DeptName FROM EMPLOYEE emp LEFT JOIN DEPT dep ON emp.EmpDeptId=dep.DeptID
UNION ALL
SELECT emp.EmpName, emp.EmpSalary, dep.DeptId, dep.DeptName FROM EMPLOYEE emp RIGHT JOIN DEPT dep ON emp.EmpDeptId=dep.DeptID ORDER BY DeptId;

Insert Into EMPLOYEE values (11,'Adi',35000,6);
--SELECT * FROM DEPT
--INTERSECT
--SELECT * FROM EMPLOYEE;

SELECT DISTINCT EmpName FROM EMPLOYEE;
SELECT COUNT (DISTINCT EmpName) as Total FROM EMPLOYEE;
