--From the following table write a query in SQL to retrieve all rows and columns from the employee table in the Adventureworks database.
--Sort the result set in ascending order on jobtitle.
--Table: HumanResources.Employee

SELECT * FROM [AdventureWorks2022].[HumanResources].[Employee] Order by JobTitle;

--From the following table write a query in SQL to retrieve all rows and columns from the employee table using table aliasing in the Adventureworks database. 
--Sort the output in ascending order on lastname.
--Table: Person.Person

SELECT * FROM [AdventureWorks2022].[Person].[Person] as PER order by LastName;

--From the following table write a query in SQL to return all rows and a subset of the columns (FirstName, LastName, businessentityid) from the person table in the AdventureWorks database. 
--The third column heading is renamed to Employee_id.Arranged the output in ascending order by lastname.
--Table: Person.Person

SELECT FirstName, LastName, BusinessEntityID as EmployeeID FROM [AdventureWorks2022].[Person].[Person] order by LastName;

--From the following table write a query in SQL to return only the rows for product that have a sellstartdate that is not NULL and a productline of 'T'. 
--Return productid, productnumber, and name. Arranged the output in ascending order on name
--production.Product

SELECT ProductID, ProductNumber, Name as ProductName FROM AdventureWorks2022.Production.Product WHERE SellStartDate IS NOT NULL and ProductLine='T' order by Name;

--From the following table write a query in SQL to return all rows from the salesorderheader table in Adventureworks database
--Calculate the percentage of tax on the subtotal have decided. Return salesorderid, customerid, orderdate, subtotal, percentage of tax column. 
--Arranged the result set in descending order on subtotal.
--Sample table: sales.salesorderheader

SELECT SalesOrderID, CustomerID, OrderDate, SubTotal, (TaxAmt/SubTotal)*100 AS Tax_Percent FROM AdventureWorks2022.Sales.SalesOrderHeader order by SubTotal DESC;

--From the following table write a query in SQL to create a list of unique jobtitles in the employee table in Adventureworks database.
--Return jobtitle column and arranged the resultset in ascending order.
--Sample table: HumanResources.Employee

SELECT Distinct JobTitle FROM AdventureWorks2022.HumanResources.Employee order by JobTitle;

--From the following table write a query in SQL to calculate the total freight paid by each customer. 
--Return customerid and total freight. Sort the output in ascending order on customerid.
--Sample table: sales.salesorderheader

SELECT CustomerID, Sum(Freight) as 'Total Freight' FROM AdventureWorks2022.Sales.SalesOrderHeader Group By CustomerID order by CustomerID;

--From the following table write a query in SQL to find the average and the sum of the subtotal for every customer. 
--Return customerid, average and sum of the subtotal.
--Grouped the result on customerid and salespersonid. Sort the result on customerid column in descending order.
--Sample table: sales.salesorderheader

SELECT CustomerID,SalesPersonID, Avg(SubTotal)as 'Average Total', SUM(SubTotal) as sum_subtotal FROM AdventureWorks2022.Sales.SalesOrderHeader Group by SalesPersonID,CustomerID Order By CustomerID DESC;

--From the following table write a query in SQL to retrieve total quantity of each productid which are in shelf of 'A' or 'C' or 'H'.
--Filter the results for sum quantity is more than 500.
--Return productid and sum of the quantity. Sort the results according to the productid in ascending order.
--Sample table: production.productinventory

SELECT ProductID, SUM(Quantity) as SUMM FROM AdventureWorks2022.Production.ProductInventory Where Shelf IN ('A','C','H') Group by ProductID Having SUM(Quantity)>500 order by ProductID;

--From the following table write a query in SQL to find the total quentity for a group of locationid multiplied by 10.
--Sample table: production.productinventory

SELECT SUM(Quantity) as 'Total Quantity' FROM AdventureWorks2022.Production.ProductInventory Group By (LocationID);