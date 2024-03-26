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

SELECT StudentsID, Count(BooksId) as 'No. of Books' FROM AdventureReaders GROUP BY StudentsID;
SELECT StudentsID, Count(BooksId) as 'No. of Books' FROM AdventureReaders GROUP BY StudentsID HAVING COUNT(BooksId)>=2;
SELECT StudentsID, Count(BooksId) as 'No. of Books' FROM AdventureReaders GROUP BY StudentsID ORDER BY COUNT(BooksId) DESC;

SELECT 
*
FROM AdventureStudents
INNER JOIN AdventureReaders ON AdventureStudents.StudentsID=AdventureReaders.StudentsID;

CREATE TABLE AdventureInterns (Name varchar(20),InternID int NOT NULL, Company varchar (20));

SELECT * FROM AdventureInterns;

INSERT INTO AdventureInterns VALUES('Subhendu',2345,'GyanSys'),
							('Arman',1234,'Plivo'),
							('Vinu',2231,'ITC Infotech'),
							('Ritvik',1235,'IBS Software'),
							('Shriyans',5432,'Securonix'),
							('Raj Ronak',1231,'KFintech');
INSERT INTO AdventureInterns VALUES('Pratik',2345,'GyanSys');

UPDATE AdventureInterns SET Company='NSL Hub' WHERE InternId=2345;
