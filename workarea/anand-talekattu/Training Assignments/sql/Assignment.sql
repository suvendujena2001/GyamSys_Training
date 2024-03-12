use AdventureWorks2022;

--To rename table
EXEC sp_rename 'Production.ProductReview','ProReview';
EXEC sp_rename 'Production.ProReview','ProductReview';

--To rename column
EXEC sp_rename 'Production.ProductReview.Comments','ProComments';
EXEC sp_rename 'Production.ProductReview.ProComments','Comments';

--create procedure
create procedure spGetEmployee
AS
BEGIN 
SELECT BusinessEntityID,Gender FROM HumanResources.Employee
END
--execute procedure
spGetEmployee

--CTE
--get employees who has sick leaves more than average sick leaves of all employee
WITH average_sick(avg_sick) AS (SELECT AVG(SickLeaveHours) FROM HumanResources.Employee)
SELECT * FROM HumanResources.Employee,average_sick WHERE SickLeaveHours>avg_sick;

