use AdventureWorks2022
-- here i display all column and rows of the table
select * from [HumanResources].[Employee]
-- here i display only loginid and jobtitle
select LoginID , JobTitle from [HumanResources].[Employee]
-- here i display top 20 data of the table column loginid and jobtitle
select top 20 LoginID , JobTitle from [HumanResources].[Employee]
-- person table
select * from Person.Person

select FirstName , LastName from Person.Person

select FirstName + LastName from Person.Person

select distinct persontype from Person.Person
select count(distinct persontype) from Person.Person

select distinct persontype,EmailPromotion from Person.Person
order by EmailPromotion

select * from HumanResources.Employee
where MaritalStatus = 'M' and Gender= 'F' 

--CASE .. column .. when...then..else..end
select FirstName, LastName ,
Case persontype when 'IN' then 'Individual Customer'
when 'EM' then 'Employee'
when 'SP' then 'sales person'
when 'SC' then 'store contact'
when 'GC' then 'General contact'
when 'VC' then 'Vendor store'
else 'unknown Person type' end TypeOfContact
from person.Person

select FirstName, LastName, MiddleName from  person.Person
where MiddleName is null

select FirstName, LastName, MiddleName from  person.Person
where MiddleName is not null

select FirstName, LastName, MiddleName, EmailPromotion from  person.Person
where MiddleName is not null 
and EmailPromotion = 2

select * from person.Person
where FirstName IN('Dylan', 'Thierry','Sharon')

select * from HumanResources.Employee
where SickLeaveHours between 40 and 80

select LoginID, JobTitle from HumanResources.Employee
where JobTitle like '%manager%'

select * from Person.Person 
where FirstName like '_ary'

select * from production.product
select * from sales.SalesOrderDetail
--inner join
select a.Name as ProductName, a.ProductID, a.ProductNumber , b.SalesOrderID,b.CarrierTrackingNumber from production.product
a inner join sales.SalesOrderDetail b  on a.ProductID = b.ProductID
--left join
select a.Name as ProductName, a.ProductID, a.ProductNumber  from production.product
a left join sales.SalesOrderDetail b  on a.ProductID = b.ProductID
--right join
select a.Name as ProductName, a.ProductID, a.ProductNumber , b.SalesOrderID,b.CarrierTrackingNumber from production.product
a right join sales.SalesOrderDetail b  on a.ProductID = b.ProductID


--common table expression (CTE)
WITH my_cte AS (
select FirstName, LastName, MiddleName from  person.Person )
select FirstName, LastName from my_cte;

