SELECT TOP (1000) [EmpId]
      ,[FirstName]
      ,[LastName]
      ,[Email]
      ,[Salary]
      ,[DeptId]
  FROM [AdventureWorks2022].[dbo].[Employee]

  select * from Employee;

  select avg(Salary)as Average
  from Employee;

  select DeptId,Avg(Salary) As Average from Employee group by DeptId;


  --COUNT :aggregate function that is used to find number of values in specified column excluding null values.

  select COUNT(FirstName) as "Total" from Employee;

  select count(distinct(LastName))as "total" from Employee;

  select DeptId , COUNT (*) as "Total Employees" 
  From Employee
  Group By DeptId;


  -- MAX FUNCTION :aggregate function used to find the largest value in given column or expression.

  select MAX(Salary) as "Highest Salary" from Employee;

  select * from Employee 
  where Salary = (select MAX(Salary) from Employee);

  select DeptId , MAX(Salary) as "Highest Salary " 
  From Employee
  Group by DeptId;

  select MAX(FirstName) as "Largest FName" from Employee;

  --MIN FUNCTION : aggregate function used to find the smallest value of given column expression.

  select min(salary) as "Smallest Salary" from Employee;

  select * from Employee
  where Salary =(Select MIN(Salary) from Employee);

  select DeptId , MIN(Salary) as "Smallest Salary" 
  From Employee
  Group by DeptId;

  Select Min(FirstName) as "Smallest FName " From Employee;

  --SUM FUNCTION : used to find the sum of given column or an expression.

  select sum(salary) as "Total Salary " From Employee;

  select deptid , sum(salary) as "Department wise Total Salary" 
  From Employee
  Group By deptid;

