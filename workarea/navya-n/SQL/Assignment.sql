//stored procedures
CREATE procedure [dbo].[changename]
@Name nvarchar(50)
AS 
update HumanResources.Department set Name = @Name
where Name = 'Tool Design';


create procedure getpersons
as select * from person.person;


//JOINS
//Innerjoin
select * from person.BusinessEntity BE 
inner join Person.EmailAddress BEA 
on 
BE.BusinessEntityID=BEA.BusinessEntityID;


//Leftjoin
select SP.SalesQuota, SPQ.QuotaDate from Sales.SalesPerson SP 
left join Sales.SalesPersonQuotaHistory SPQ
on 
SP.BusinessEntityID=SPQ.BusinessEntityID;

//Rightjoin
select  ST.CostLastYear, CRC.CurrencyCode from Sales.SalesTerritory ST 
right join Sales.CountryRegionCurrency CRC
on 
CRC.CountryRegionCode=ST.CountryRegionCode;


//altertable adding newcolumn
alter table HumanResources.Shift 
add NumberofHours int;

select * from HumanResources.Shift

//altertable renaming columns
select * from Person.Address
exec sp_rename 'Person.Address.PostalCode' , 'ZIPCode'

