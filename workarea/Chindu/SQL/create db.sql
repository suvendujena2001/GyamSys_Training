CREATE DATABASE CHINDU; -- creating a database
GO

USE CHINDU;
GO

CREATE TABLE EMPLOYEES
(
    ID INT IDENTITY PRIMARY KEY,
    FIRST_NAME VARCHAR(20),
    LAST_NAME VARCHAR(30) NOT NULL,
    EMAIL VARCHAR(30),
    SALARY INT
);
GO

INSERT INTO EMPLOYEES(FIRST_NAME,LAST_NAME,EMAIL,SALARY) -- inserting data into the EMPLOYEES table.
VALUES
('ARIN','RAJ','raj@gmail.com', 40000),
('manoj','kumar','manoj@yahoo.com', 40000);
GO

SELECT * FROM EMPLOYEES;
