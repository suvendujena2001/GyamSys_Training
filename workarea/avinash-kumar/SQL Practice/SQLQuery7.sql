use AdventureWorks2022;

/*select p.PhoneNumber, t.Name from Person.PersonPhone as p
inner join Person.PhoneNumberType as t
on p.PhoneNumberTypeID=t.PhoneNumberTypeID;
*/

select * from Person.PhoneNumberType t
right join Person.PersonPhone as p
on t.PhoneNumberTypeID=p.PhoneNumberTypeID;


select * from Person.PhoneNumberType t
full join Person.PersonPhone as p
on t.PhoneNumberTypeID=p.PhoneNumberTypeID;


select * from Person.PersonPhone
intersect select * from Person.PersonPhone;