select * from Department;
select * from Employee1;
exec sp_rename 'Department.emptid','empdeptid','column';
--1. INNER JOIN

select d.empdeptid,d.deptName,e.empsalary,e.empname from Employee1 as  e
inner join Department as  d on
 d.empdeptid=e.empdeptid;

 --2 RIGHT JOIN

 select d.empdeptid,d.deptName,e.empsalary,e.empname from Employee1 as  e
right join Department as  d on
 d.empdeptid=e.empdeptid;

  --3 LEFT JOIN

  select d.empdeptid,d.deptName,e.empsalary,e.empname from Employee1 as  e
left join Department as  d on
 d.empdeptid=e.empdeptid;

  --4 FULL JOIN

  select d.empdeptid,d.deptName,e.empsalary,e.empname from Employee1 as  e
full join Department as  d on d.empdeptid=e.empdeptid;

