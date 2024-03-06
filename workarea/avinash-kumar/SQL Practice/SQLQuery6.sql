SELECT TOP (1000) [BusinessEntityID]
      ,[DepartmentID]
      ,[ShiftID]
      ,[StartDate]
      ,[EndDate]
      ,[ModifiedDate]
  FROM [AdventureWorks2022].[HumanResources].[EmployeeDepartmentHistory]
  


  --when date is not in proper format
  SELECT DATENAME(month,TRY_CONVERT(DATE, PostTime)) as year
from dbo.DatabaseLog;


--date in proper format, finding 
  
  seLECT startdate as date ,datename(dw,startdate) as "name of the day"
from HumanResources.EmployeeDepartmentHistory;

