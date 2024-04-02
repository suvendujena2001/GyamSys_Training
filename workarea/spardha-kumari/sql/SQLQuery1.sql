/*SELECT e.*  
FROM person.person AS e  
ORDER BY LastName;
select * from HumanResources.Department ;*/



SELECT firstname, lastname, businessentityid as Employee_id  
FROM person.person AS e  
ORDER BY lastname;

SELECT e.*  
FROM person.person AS e  
ORDER BY LastName;


SELECT firstname, lastname, businessentityid as Employee_id  
FROM person.person AS e  
ORDER BY lastname;

SELECT salesorderid,customerid,orderdate,subtotal,
(taxamt*100)/subtotal AS Tax_percent
FROM sales.salesorderheader
ORDER BY subtotal desc;

SELECT pc.ContactTypeID, pc.Name AS CTypeName, COUNT(*) AS NOcontacts
    FROM Person.BusinessEntityContact AS pbe
        INNER JOIN Person.ContactType AS pc
            ON pc.ContactTypeID = pbe.ContactTypeID
    GROUP BY pc.ContactTypeID, pc.Name
	HAVING COUNT(*) >= 100
    ORDER BY COUNT(*) DESC;

	ALTER TABLE  Person.AddressType ADD Group_code varchar(200); 
	

/*use sample_db;


CREATE TABLE Personsll (
    ID int NOT NULL,
    LastName varchar(255) NOT NULL,
    FirstName varchar(255),
    Age int,
    CONSTRAINT UC_Person UNIQUE (ID,LastName)
);*/
