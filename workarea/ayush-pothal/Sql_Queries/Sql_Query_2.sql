   CREATE TABLE Employee(
    EmpId integer, 
    FirstName varchar(20), 
    LastName varchar(20), 
    Email varchar(25), 
    PhoneNo varchar(25), 
    Salary integer
    );

--DML Statements

--INSERT Statement
INSERT INTO Employee
 VALUES(1,'Ayush','Pothal','ayushpothal@abc.com','1234567890',63000, 100002);


--UPDATE Statement
UPDATE Employee
SET Email = 'updatedemail@test.com'
WHERE EmpId = 1;

--DELETE Statement
DELETE FROM Employee WHERE EmpId = 1;

--TRUNCATE Statement
TRUNCATE TABLE Employee;
