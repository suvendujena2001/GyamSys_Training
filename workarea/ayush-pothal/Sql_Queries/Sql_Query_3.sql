CREATE TABLE Employee_db(
    EmpId integer, 
    FirstName varchar(20), 
    LastName varchar(20), 
    Email varchar(25), 
    PhoneNo varchar(25), 
    Salary integer
);

 INSERT INTO Employee
 VALUES(1,'Ayush','Pothal','ayushpothal@abc.com','1234567890',63000, 100002);
  INSERT INTO Employee
 VALUES(2,'Swagat','Sahu','swagatsahu@abc.com','7685904321',37000, 100070);
  INSERT INTO Employee
 VALUES(1,'Rajnikant','pattnaik','rajnipattnaik@abc.com','8789543251',54000, 100707);
  INSERT INTO Employee
 VALUES(2,'Swayam','Sahu','swayamsahu\@abc.com','456312819',50000, 700012);
  INSERT INTO Employee
 VALUES(1,'Suvam','Panda','suvampanda@abc.com','9876543210',66000, 800002);
     
--SELECT statement
SELECT * FROM Employee_db;

--WHERE Clause
SELECT * FROM Employee_db
WHERE Salary>50000;

--GROUP BY Clause
SELECT EmpId, COUNT(*) as 'No of Employees' 
FROM Employee_db
GROUP BY EmpId;

--HAVING Clause
SELECT EmpId, COUNT(*) as 'No of Employees'
FROM Employee_db
GROUP BY EmpId
HAVING count(EmpId)>2;

--ORDER BY Clause
SELECT * FROM Employee_db
ORDER BY FirstName;

