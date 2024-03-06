SELECT TOP (1000) [BusinessEntityID]
      ,[RateChangeDate]
      ,[Rate]
      ,[PayFrequency]
      ,[ModifiedDate]
  FROM [AdventureWorks2022].[HumanResources].[EmployeePayHistory]


select businessentityid from HumanResources.EmployeePayHistory
where rate>=26;


