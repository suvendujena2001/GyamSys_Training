SELECT TOP (1000) [ProductModelID]
      ,[Name]
      ,[CatalogDescription]
      ,[Instructions]
      ,[rowguid]
      ,[ModifiedDate]
  FROM [AdventureWorks2022].[Production].[ProductModel]

  select productmodelid from Production.ProductModel
  where CatalogDescription is not null or Instructions is not null ;


  select * from  Production.ProductModel
  where name like 'M_%' and ProductModelID<=40 ;







