create table Departments
(
 ID int primary key identity,
 Name nvarchar(50),
 Location nvarchar(50)

)

create table Student(
 ID int primary key identity,
 FName nvarchar(50),
 LName nvarchar(50),
 Gender nvarchar(50),
 Fees int,
 DepartmentId int foreign key references Departments(Id)
)

Insert into Departments values ('Engineering','Block A')
Insert into Departments values ('Law','Block B')
Insert into Departments values ('commerce','Block C')

Insert into Student values ('ABC','Cross','Male', 200000,1)
Insert into Student values ('qwe','Cross1','Male', 300000,2)
Insert into Student values ('qwer','Cross2','Male', 400000,1)
