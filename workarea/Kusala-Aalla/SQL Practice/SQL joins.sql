CREATE TABLE EMPLOYEES(EMPID INT,EMPFIRSTNAME VARCHAR(50),EMPLASTNAME VARCHAR(50),EMPSALARY INT,EMPDEPTID INT);

INSERT INTO EMPLOYEES VALUES(1,'KUSALA','AALLA',50000,1);
INSERT INTO EMPLOYEES VALUES(8,'GAYATHRI','ANNAREDDY',60000,2);
INSERT INTO EMPLOYEES VALUES(4,'JYOSHNA','CHEEKALA',40000,5);
INSERT INTO EMPLOYEES VALUES(6,'HARI','PATNAM',20000,1);
INSERT INTO EMPLOYEES VALUES(7,'PREETHAM','VADDI',10000,3);
INSERT INTO EMPLOYEES VALUES(2,'JOHN','DOE',5000,3);
INSERT INTO EMPLOYEES VALUES(3,'HARSHA','VARDHAN',30000,2);
INSERT INTO EMPLOYEES VALUES(7,'KUNDHANA','PRIYA',45000,1);
INSERT INTO EMPLOYEES VALUES(6,'MANOJ','KUMAR',60000,2);

SELECT * FROM EMPLOYEES

CREATE TABLE DEPT1(DEPTID INT,DEPTNAME VARCHAR(100));

INSERT INTO DEPT1 VALUES(1,'MICROSOFT');
INSERT INTO DEPT1 VALUES(2,'SALESFORCE');
INSERT INTO DEPT1 VALUES(3,'SAP');
INSERT INTO DEPT1 VALUES(4,'DATA ANALYST');
INSERT INTO DEPT1 VALUES(5,'OPEN SOURCE');

SELECT * FROM DEPT1

SELECT Employees.EmpId, Employees.EmpFirstName, Employees.EmpLastName, Dept1.DeptName 
FROM Employees
INNER JOIN Dept1
ON Employees.EmpDeptId = Dept1.DEPTID;


SELECT Employees.EmpId, Employees.EmpFirstName, Employees.EmpLastName, Dept1.DeptName 
FROM Employees
RIGHT JOIN Dept1
ON Employees.EmpDeptId = Dept1.Deptid;


SELECT Employees.EmpId, Employees.EmpFirstName, Employees.EmpLastName, Dept1.DeptName 
FROM Employees
LEFT JOIN Dept1
ON Employees.EmpDeptId = Dept1.DeptId;


SELECT Employees.EmpId, Employees.EmpFirstName, Employees.EmpLastName, Dept1.DeptName 
FROM Employees
FULL JOIN Dept1
ON Employees.EmpDeptId = Dept1.DeptId;




SELECT AVG(EmpSalary) AS AVERAGE FROM Employees;  --average salary of all employees

SELECT EmpDeptId, AVG(EmpSalary) AS AVERAGE FROM Employees GROUP BY EmpDeptId;  --average salary of each deparatment


select count(empfirstname) As total from employees;  --count the total records in firstname column

select count(distinct(emplastname)) As average from employees;

select count(*) As "Total records" from employees;  --count the total records in the table


select max(empsalary) As "highest salary" from employees;  --selects the maximum salary from the table

select * from employees
where empsalary = (select max(empsalary) from employees);  --gets whose salary is maximum

select max(empfirstname) As "largest first name" from employees;   --selects the largest first name


select min(empsalary) As "smallest salary" from employees;  --selects the smallest salary

select * from employees
where empsalary = (select min(empsalary) from employees);  --gets whose salary is minimum

select min(empfirstname) As "smallest first name" from employees;   --selects the smallest firstname

select sum(empsalary) As "total salary" from employees;  --gets total salary of all employees

select empdeptid,sum(empsalary) As "deparatment wise total salary" from employees
group by empdeptid;    --gets the total salary of each deparatment