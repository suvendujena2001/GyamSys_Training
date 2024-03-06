SELECT TOP (1000) [CustomerID]
      ,[PersonID]
      ,[StoreID]
      ,[TerritoryID]
      ,[AccountNumber]
      ,[rowguid]
      ,[ModifiedDate]
  FROM [AdventureWorks2022].[Sales].[Customer]

  select t.Group as group,t.Name,t.CountryRegionCode from Sales.Customer as s
  right join Sales.SalesTerritory as t
  on s.TerritoryID=t.TerritoryID
  where t.Group = 'europe';