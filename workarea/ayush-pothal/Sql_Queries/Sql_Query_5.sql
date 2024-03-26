--SQL Operators

CREATE TABLE EMPLOYEE(EmpId integer,EmpName VARCHAR(100),EmpSalary integer, DeptId integer);

INSERT INTO EMPLOYEE(EmpId,EmpName,EmpSalary,DeptId)
VALUES(1,'ANAND',70000,1),
(2,'KALPANA',10000,2),
(3,'SUBHASIS',23000,2),
(4,'MAMA',3400,1),
(5,'SUVAM',8700,3),
(6,'SWAYAM',6700,1),
(7,'SWAGAT',8346,3),
(8,'AYUSH',7600,3),
(9,'SUBHENDU',3000,1),
(10,'PANIGRAHI',7000,2);
 
SELECT * FROM EMPLOYEE;

CREATE TABLE DEPT(DeptId integer,DeptName VARCHAR(100));

INSERT INTO DEPT(DeptId,DeptName)
VALUES(1,'MICROSOFT'),
(2,'SAP'),
(3,'SALESFORCE'),
(4,'DA');

SELECT * FROM DEPT;

--BETWEEN 
SELECT EmpId, EmpName, EmpSalary
FROM EMPLOYEE
WHERE EmpSalary BETWEEN 3000 AND 5000;


--IN
SELECT EmpId, EmpName, EmpSalary
FROM EMPLOYEE
WHERE EmpId IN(1,3,5);


--LIKE
SELECT EmpId, EmpName, EmpSalary
FROM EMPLOYEE
WHERE EmpName LIKE 'a%';


CREATE TABLE TableA (
    Id integer PRIMARY KEY,
    Name VARCHAR(50),
    Age integer,
	Salary integer
    );

INSERT INTO TableA(Id, Name, Age, Salary)
VALUES(1,'Ayush',22,10000),
      (2,'Pothal',22,20000),
	  (3,'Anand',21,40000),
	  (4,'Swagat',22,50000),
	  (5,'Suvam',21,40000);

	  SELECT * FROM TableA;
	  
	CREATE TABLE TableB (
    Id integer PRIMARY KEY,
    Name VARCHAR(50),
    Age integer,
	Salary integer
    );

	INSERT INTO TableB(Id, Name, Age, Salary)
    VALUES(1,'Ayush',21,10000),
      (2,'Pothal',22,50000),
	  (3,'Anand',21,40000),
	  (4,'Swagat',22,50000),
	  (5,'Suvam',21,40000);

	  SELECT * FROM TableB;

--INTERSECT
SELECT * FROM TableA
INTERSECT
SELECT * FROM TableB;

--MINUS
SELECT * FROM TableA
MINUS
SELECT * FROM TableB;

--UNION
SELECT * FROM TableA
UNION
SELECT * FROM TableB;

--UNION ALL
SELECT * FROM TableA
UNION ALL
SELECT * FROM TableB;


--DISTINCT
SELECT DISTINCT Age FROM TableA;


--ANY
SELECT * FROM EMPLOYEE
WHERE DeptId = ANY(
                    SELECT DeptId FROM DEPT
                    WHERE DeptName='MICROSOFT' OR DeptName='SAP'
                  );

--SOME
SELECT * FROM EMPLOYEE
WHERE DeptId = SOME(
                    SELECT DeptId FROM DEPT
                    WHERE DeptName='MICROSOFT' OR DeptName='SAP'
                  );



--ALL
SELECT * FROM EMPLOYEE
WHERE DeptId = ALL(
                    SELECT DeptId FROM DEPT
                    WHERE DeptName='MICROSOFT'
                  );
