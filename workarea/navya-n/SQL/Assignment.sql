--stored procedures
CREATE procedure [dbo].[changename]
@Name nvarchar(50)
AS 
update HumanResources.Department set Name = @Name
where Name = 'Tool Design';


create procedure getpersons
as select * from person.person;


--JOINS
--Innerjoin
select * from person.BusinessEntity BE 
inner join Person.EmailAddress BEA 
on 
BE.BusinessEntityID=BEA.BusinessEntityID;


--Leftjoin
select SP.SalesQuota, SPQ.QuotaDate from Sales.SalesPerson SP 
left join Sales.SalesPersonQuotaHistory SPQ
on 
SP.BusinessEntityID=SPQ.BusinessEntityID;

--Rightjoin
select  ST.CostLastYear, CRC.CurrencyCode from Sales.SalesTerritory ST 
right join Sales.CountryRegionCurrency CRC
on 
CRC.CountryRegionCode=ST.CountryRegionCode;


--altertable adding newcolumn
alter table HumanResources.Shift 
add NumberofHours int;

select * from HumanResources.Shift

--altertable renaming columns
select * from Person.Address
exec sp_rename 'Person.Address.PostalCode' , 'ZIPCode'

--create db,table and add constraint
create database EmployeeRecords;


use EmployeeRecords
Go
create table Employee(
ID int NOT NULL,
Name nvarchar(25),
Email nvarchar(30),
Phone varchar,
CONSTRAINT PK_id PRIMARY KEY CLUSTERED (ID)
)

--adding records
USE EmployeeRecords
go

insert into Employee values(2172,'Navya','navya.narayan@gyansys.com',6360374059);
select * from Employee;
