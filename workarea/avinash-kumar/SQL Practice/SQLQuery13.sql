SELECT TOP (1000) [ProductID]
      ,[ProductPhotoID]
      ,[Primary]
      ,[ModifiedDate]
  FROM [AdventureWorks2022].[Production].[ProductProductPhoto]


  select count(productphotoid) as one
  from Production.ProductProductPhoto
  where ProductPhotoID=1;