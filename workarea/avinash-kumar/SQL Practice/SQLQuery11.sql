select b.BusinessEntityID,b.ContactTypeID,b.PersonID from Person.BusinessEntityContact b
right join Person.ContactType c
on b.ContactTypeID=c.ContactTypeID;

select b.BusinessEntityID,b.ContactTypeID,b.PersonID from Person.BusinessEntityContact b
left join Person.ContactType c
on b.ContactTypeID=c.ContactTypeID;

select b.BusinessEntityID,b.ContactTypeID,b.PersonID from Person.BusinessEntityContact b
inner join Person.ContactType c
on b.ContactTypeID=c.ContactTypeID;

select b.BusinessEntityID,b.ContactTypeID,b.PersonID from Person.BusinessEntityContact b
full join Person.ContactType c
on b.ContactTypeID=c.ContactTypeID;
