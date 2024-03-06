select * from [HumanResources].[Employee]

create procedure select_all_data 
as
select * from [HumanResources].[Employee]
go;

exec select_all_data;


create view B_ID
as
select BusinessEntityID from [HumanResources].[Employee];

select * from B_ID;



  create table HumanResources.TempShift
  (
	TempShift_ID tinyint NOT Null, Name nvarchar(50)
	, constraint PK_TempShift PRIMARY KEY (TempShift_ID)
	, constraint FK_TempShift_HumanResource FOREIGN KEY(TempShift_ID)
	REFERENCES HumanResources.Shift (ShiftID)
	on delete cascade
	on update cascade
	);

	insert into HumanResources.Shift (ShiftID, Name)
	values (4 ,'Afternoon');


	
SELECT ProductID, Purchasing.Vendor.BusinessEntityID, Name
FROM Purchasing.ProductVendor INNER JOIN Purchasing.Vendor
    ON (Purchasing.ProductVendor.BusinessEntityID = Purchasing.Vendor.BusinessEntityID)
WHERE StandardPrice > $10
  AND Name LIKE N'F%';
GO



WITH CTE1 AS (SELECT DepartmentID, Name FROM HumanResources.Department)
SELECT * FROM CTE1;

