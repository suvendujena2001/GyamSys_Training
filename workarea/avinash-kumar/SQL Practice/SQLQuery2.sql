--SELECT * FROM HumanResources.Department;

--SELECT TOP 3 *FROM HumanResources.Department;

--SELECT * FROM Person.Person;

--ALTER TABLE "HumanResources.Department" RENAME TO "HR.DEP;
EXEC sp_rename 'HumanResources.Department' , 'HR.DEP';
--SELECT * FROM HumanResources.;
/*SELECT TOP 5 * FROM Production.Product 
Order BY ReorderPoint DESC;*/

select * from HumanResources.




