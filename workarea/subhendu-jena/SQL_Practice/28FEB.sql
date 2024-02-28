CREATE TABLE Students(ID int primary key, Name varchar(20),Email varchar(50) NOT NULL);

ALTER TABLE Students ADD Dept varchar(20);

INSERT INTO Students VALUES (1,'Subhendu','abc','CSE'),
							(2,'Ayush','bcd','IT'),
							(3,'Swagat','cde','CSE'),
							(4,'Swayam','def','CSE'),
							(5,'Subhasis','efg','ECE'),
							(6,'Kalpana','fgh','ECE');
SELECT * FROM Students;

EXEC sp_rename 'Students.Name','StudentsName';
EXEC sp_rename 'Students.Email','StudentsEmail';
EXEC sp_rename 'Students.Dept','Department';
Exec sp_rename 'Students.ID','StudentsID';

ALTER TABLE Students ADD MOBILE varchar(10);

ALTER TABLE STUDENTS ALTER COLUMN MOBILE int;

ALTER TABLE Students DROP COLUMN MOBILE;

EXEC sp_rename '[dbo].[Students]','AdventureStudents';


CREATE TABLE AdventureReaders (LibraryID int Primary Key,BooksId int NOT NULL, StudentsID int FOREIGN KEY REFERENCES AdventureStudents(StudentsID)); 

SELECT * FROM AdventureReaders;
SELECT * FROM AdventureStudents;

INSERT INTO AdventureReaders VALUES(1,2345,3),
							(2,1234,2),
							(3,2231,3),
							(4,1235,1),
							(5,5432,1),
							(6,1231,4);

SELECT 
*
FROM AdventureStudents
INNER JOIN AdventureReaders ON AdventureStudents.StudentsID=AdventureReaders.StudentsID;