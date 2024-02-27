use AdventureWorks2022;
/*1. From the following table write a query in SQL to return only the rows for product that have a 
sellstartdate that is not NULL and a productline of 'T'. Return productid, productnumber, and name.
Arranged the output in ascending order on name.*/
SELECT ProductID,ProductNumber, Name FROM Production.Product 
WHERE SellStartDate IS NOT NULL AND ProductLine='T' ORDER BY Name;

/*2. From the following table write a query in SQL to return all rows from the salesorderheader table 
in Adventureworks database and calculate the percentage of tax on the subtotal have decided. Return salesorderid,
customerid, orderdate, subtotal, percentage of tax column. Arranged the result set in ascending order on subtotal.
Sample table: sales.salesorderheader*/
SELECT SalesOrderID, CustomerID,OrderDate,SubTotal,(TaxAmt/SubTotal)*100 AS tax_percent 
FROM Sales.SalesOrderHeader ORDER BY SubTotal;

/*3. From the following table write a query in SQL to create a list of unique jobtitles in the employee table
in Adventureworks database. Return jobtitle column and arranged the resultset in ascending order.
Sample table: HumanResources.Employee*/
SELECT DISTINCT JOBTITLE FROM HumanResources.Employee ORDER BY JobTitle;

/*4.From the following table write a query in SQL to calculate the total freight paid by each customer. 
Return customerid and total freight. Sort the output in ascending order on customerid.
Sample table: sales.salesorderheader*/
SELECT CustomerID,SUM(Freight) AS total_freight FROM SALES.SalesOrderHeader 
GROUP BY CustomerID ORDER BY CustomerID;

/*5. From the following table write a query in SQL to find the average and the sum of the subtotal for every customer.
Return customerid, average and sum of the subtotal. Grouped the result on customerid and salespersonid.
Sort the result on customerid column in descending order.
Sample table: sales.salesorderheader*/
SELECT CustomerID,SalesPersonID,AVG(SubTotal) AS average_total,SUM(SubTotal) AS total FROM Sales.SalesOrderHeader 
GROUP BY CustomerID, SalesPersonID ORDER BY CustomerID;

/*6. From the following table write a query in SQL to retrieve total quantity of each productid which
are in shelf of 'A' or 'C' or 'H'. Filter the results for sum quantity is more than 500. 
Return productid and sum of the quantity. Sort the results according to the productid in ascending order.
Sample table: production.productinventory*/
SELECT ProductID,SUM(Quantity)AS total_qty FROM Production.ProductInventory 
WHERE Shelf IN('A','C','H') GROUP BY ProductID ; 

/*7. From the following table write a query in SQL to find the total quentity for a group of locationid multiplied by 10.
Sample table: production.productinventory*/
SELECT SUM(Quantity) AS total_qty FROM Production.ProductInventory GROUP BY (LocationID*10);

/*8. From the following tables write a query in SQL to find the persons whose last name starts with letter 'L'. 
Return BusinessEntityID, FirstName, LastName, and PhoneNumber. Sort the result on lastname and firstname.
Sample table: Person.PersonPhone
Sample table: Person.Person*/
SELECT P.BusinessEntityID,FirstName,LastName,PhoneNumber 
FROM Person.PersonPhone PH JOIN Person.Person P ON PH.BusinessEntityID=P.BusinessEntityID
WHERE LastName LIKE 'L%';

/*9. From the following table write a query in SQL to find the sum of subtotal column. Group the sum on distinct 
salespersonid and customerid. Rolls up the results into subtotal and running total. 
Return salespersonid, customerid and sum of subtotal column i.e. sum_subtotal.
Sample table: sales.salesorderheader*/
SELECT SalesPersonID,CustomerID,SUM(SubTotal) FROM Sales.SalesOrderHeader GROUP BY CUBE(SalesPersonID,CustomerID);

/*10. From the following table write a query in SQL to find the sum of the quantity of all combination of 
group of distinct locationid and shelf column. Return locationid, shelf and sum of quantity as TotalQuantity.
Sample table: production.productinventory*/
SELECT LocationID,Shelf,SUM(Quantity) FROM Production.ProductInventory GROUP BY CUBE(LocationID,Shelf);

/*11. From the following table write a query in SQL to find the total quantity for each locationid 
and calculate the grand-total for all locations. Return locationid and total quantity. Group the results on locationid.
Sample table: production.productinventory*/
SELECT locationid, SUM(quantity) AS TotalQuantity
FROM production.productinventory
GROUP BY GROUPING SETS ( locationid, () );

/*12. From the following table write a query in SQL to retrieve the number of employees for each City. 
Return city and number of employees. Sort the result in ascending order on city.
Sample table: Person.BusinessEntityAddress*/
SELECT City, COUNT(*) FROM Person.BusinessEntityAddress PB JOIN Person.Address PA ON PB.AddressID=PA.AddressID 
GROUP BY PA.City ORDER BY City;


/*13. From the following table write a query in SQL to retrieve the total sales for each year. 
Return the year part of order date and total due amount. Sort the result in ascending order on year part of order date.
Sample table: Sales.SalesOrderHeader*/
SELECT DATEPART(YEAR,OrderDate) AS ORDER_YEAR,SUM(TotalDue) AS ORDER_AMT FROM Sales.SalesOrderHeader 
GROUP BY DATEPART(YEAR,OrderDate) ORDER BY ORDER_YEAR; 

/*14. From the following table write a query in SQL to retrieve the total sales for each year. 
Filter the result set for those orders where order year is on or before 2016. 
Return the year part of orderdate and total due amount. Sort the result in ascending order on year part of order date.
Sample table: Sales.SalesOrderHeader*/
SELECT DATEPART(YEAR,OrderDate) AS ORDER_YEAR,SUM(TotalDue) AS ORDER_AMT FROM Sales.SalesOrderHeader 
GROUP BY DATEPART(YEAR,OrderDate) HAVING DATEPART(YEAR,OrderDate)<=2016 ORDER BY ORDER_YEAR;

/*15. From the following table write a query in SQL to find the contacts who are designated as 
a manager in various departments. Returns ContactTypeID, name. Sort the result set in descending order.
Sample table: Person.ContactType*/
SELECT ContactTypeID,NAME FROM Person.ContactType WHERE Name LIKE '%MANAGER%' ORDER BY ContactTypeID DESC;

/*16. From the following tables write a query in SQL to make a list of contacts who are designated as 
'Purchasing Manager'. Return BusinessEntityID, LastName, and FirstName columns. 
Sort the result set in ascending order of LastName, and FirstName.
Sample table: Person.BusinessEntityContact
Sample table: Person.ContactType
Sample table: Person.Person*/
SELECT PP.BusinessEntityID,FirstName,LastName FROM Person.BusinessEntityContact PB JOIN Person.ContactType PC ON PB.ContactTypeID=PC.ContactTypeID 
JOIN Person.Person PP ON PB.PersonID=PP.BusinessEntityID WHERE pc.Name = 'Purchasing Manager' ORDER BY LastName,FirstName
SELECT * FROM Person.BusinessEntityContact

/*Create procedure*/
create procedure spGetEmployee
AS
BEGIN 
SELECT BusinessEntityID,Gender FROM HumanResources.Employee
END

spGetEmployee
