--SQL PART--1 

-- 1.Create a database.
create database soumyadip;
-- 2.Using that database
use soumyadip;
-- 3.Create a table in that database 
create table employee(empid integer not null primary key, fname varchar(30), lname varchar(30), address varchar(50),phoneno varchar(10));
-- 4. insert values into the table
insert into employee values(1,'soumyadip','dhara','west bengal','9382063695';);
-- 5.Adding new column
alter table employee add (pincode varchar(6),salary integer);
-- 6. Rename column
alter table employee rename column pincode to zipcode;
EXEC sp_rename 'pincode', 'zipcode', 'COLUMN';
-- 7.Change the column datatype size
alter table employee alter column fname varchar(50);
-- 8. Delete a column
alter table employee drop column salary;
-- 9.Rename a table
alter table employee rename to employees;
exec sp_rename 'employee','employees';
-- 10. Delete a table
drop table employees;
-- 11. Finding null values in a column
select * from employees where zipcode is null;
-- 12. Setting null values
update employee set zipcode null where empid=1;
-- 13. Finding not null values.
select * from employees where zipcode is not null;

-- PART--2

-- 14. Insert data into a table.
insert into employees values(2,'Anand','Telakuttu','Karnataka','1234567890');
-- 15.Insert into specific column.
insert into employees(empid,fname,lname)values(3,'mukund','kumar');
-- 16. Insert Multiple records
insert into employees values(3,'abc','efg','6373665274'),(4,'xyz','mno','8735263835');
-- 17.Insert values from another table.
insert into employees(empid,fname,lname) select custid,c_fname,c_lname from customer;
-- 18. Update coulumn values.
update employees set zipcode='637258' where empid=1;
-- 19. update multiple column values
update employees set zipcode='888362',phoneno='8634627358' where empid=3;
-- 20. update a column values from another table
update employees set zipcode=(select pincode from customer where employees.empid=customer.custid);
-- 21. Delete a record from a table.
delete from employees where empid=4;
-- 22. Delete all rows from a table
delete from employees;
-- 23. Permanently delete all records from a table
truncate table employees;
-- 24. Merge two tables
merge into employees target using interns source on target.empid=source.empid 
    when matched then update target.fname=source.fname, target.lname=source.lname
    when not matched then insert into target(empid,fname,lname) values(source.empid,source.fname.source.lname);
-- 25.Select All Columns
select * from employees;
-- 26. select specific coulumns
select empid,fname,lname from employees;
-- 27. Alias for Columns and Table
select empid "employee Id",fname as 'First name' from employees;
-- 28.Operators in SELECT Statement
select empid 'employee ID', fname + ' ' + lname as "full name" from employees;
-- 29. SELECT Query with WHERE Clause
select fname,lname from employees where empid=4;
-- 30.BETWEEN Operator in WHERE Clause
select empid,fname,lname where empid BETWEEN 2 and 5;
-- 31. Multiple Conditions in WHERE Clause
select empid,fname,lname from employees where zipcode='888362' and phoneno='8634627358';
-- 32.Subquery in WHERE Clause
select * from employees where zipcode=(select pincode from interns where fname="Avi");
-- 33. Group By
select deptid count(empid) as 'employee_ID' from employees group by(deptid);
-- 34. Having
select deptid count(empid) from employees group by(depid) having count(empid)>2;
--35 .  Order by a single column
select * from employees order by fname asc;
select * from employees order by zipcode desc;
--36 . order by multiple column
select * from employees order by fname asc, zipcode desc;


--SQL part--3

--inner join 2 tables
select person.persons.prefix,person.persons.Firstname,person.persons.middlename,person.persons.lastname,
person.personphone.phonenumber from person.persons 
inner join person.personphone on person.persons.businessentityid=person.personphone.businessentityid;

--inner join 3 tables
select person.persons.prefix,person.persons.Firstname,person.persons.middlename,person.persons.lastname,
person.personphone.phonenumber,person.emailaddress.emailaddress from person.persons 
inner join person.personphone on person.persons.businessentityid=person.personphone.businessentityid 
inner join person.emailaddress on person.persons.businessentityid=person.emailaddress.businessentityid;

--Left join
select top 100 * from production.productdocument;
select product.productid,product.Name,product.color,product.standardcost,document.documentnode
from production.product product left join production.productdocument document
on product.productid=document.productid;

--right join
select product.productid,product.Name,product.color,product.standardcost,document.documentnode
from production.product product right join production.productdocument document
on product.productid=document.productid;

--full join
select product.productid,product.Name,product.color,product.standardcost,document.documentnode
from production.product product full join production.productdocument document
on product.productid=document.productid;

--between operator
select product.productid,product.Name,product.color,product.standardcost
from production.product product where product.standardcost between 10 and 100;

-- in operaor
select product.productid,product.Name,product.color,product.standardcost
from production.product product 
where standardcost in(select standardcost from production.product where standardcost>0);

--not in operator
select product.productid,product.Name,product.color,product.standardcost
from production.product product 
where standardcost not in(select standardcost from production.product where standardcost>0);

--like operator
--starting with s
select product.productid,product.Name,product.color,product.standardcost
from production.product product 
where product.name like('s%');
--ending with e
select product.productid,product.Name,product.color,product.standardcost
from production.product product 
where product.name like('%e');
--contain o
select product.productid,product.Name,product.color,product.standardcost
from production.product product 
where product.name like('%o%');
--second letter o
select product.productid,product.Name,product.color,product.standardcost
from production.product product 
where product.name like('_o%');
--second last letter o
select product.productid,product.Name,product.color,product.standardcost
from production.product product 
where product.name like('%o_');

--creating a new table from an existing table to perform intersect,union,except
SELECT * INTO abcd FROM person.persons;
select * from abcd;
--deleting some rows to perform intersect,union,except
delete from abcd where businessentityid > 500; 
--Intersect Operator
select * from person.persons intersect select * from abcd;

-- union opeartor
SELECT * FROM person.persons union select * from abcd;

--union all
SELECT * FROM person.persons union all select * from abcd;

--minus/except oprator
SELECT * FROM person.persons  except select * from abcd;

--distinct
select distinct color from production.product;
