SELECT TOP (1000) [CountryRegionCode]
      ,[Name]
      ,[ModifiedDate]
  FROM [AdventureWorks2022].[Person].[CountryRegion]


  select count(countryregioncode) as country_code from Person.CountryRegion;