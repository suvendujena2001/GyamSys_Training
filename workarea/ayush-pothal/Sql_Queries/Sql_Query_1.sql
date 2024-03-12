-- Create Table
   CREATE TABLE Employee(
    EmpId integer, 
    FirstName varchar(20), 
    LastName varchar(20), 
    Email varchar(25), 
    PhoneNo varchar(25),
	Salary integer
);

--Add Column
 ALTER TABLE Employee 
 ADD PinCode integer;


 --Insert the values in the table
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
     
-- Rename Column
EXEC sp_rename 'Employee.PinCode', 'Employee.ZipCode';

-- Change datatype
ALTER TABLE Employee ALTER COLUMN FirstName VARCHAR(50);

--Drop Column
ALTER TABLE Employee DROP COLUMN Salary;

--Rename TABLE 
EXEC sp_rename Employee, Employee_db;


select * from Employee_db; 