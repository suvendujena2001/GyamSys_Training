use AdventureWorks2022;
select * from Person.Person;
--select * from Person.Address where AddressID between 3 and 50;
ALTER TABLE Person.Person 
ADD Address VARCHAR(100);
ALter table Person.Person drop column Address;

Update Person.Person set NameStyle='1' Where BusinessEntityID='2';

Delete from Person.Person where BusinessEntityID='3';
select * from Person.Person;

    





