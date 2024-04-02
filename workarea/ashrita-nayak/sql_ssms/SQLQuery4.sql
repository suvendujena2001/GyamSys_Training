create table classXmarks(maths int , english int , physics int , chemistry int )
insert into classXmarks(maths , english, physics, chemistry) values (70,69,94,84), (58,78,93,92), (30,47,53,98)
SELECT AVG(maths) AS AVERAGE FROM classXmarks;
SELECT COUNT(physics) AS "Total" FROM classXmarks;
SELECT MAX(english) AS "Highest english marks" FROM classXmarks;
SELECT MIN(chemistry) AS "Lowest chemistry marks" FROM classXmarks;
SELECT SUM(maths) AS "Total maths marks obatined" FROM classXmarks;
SELECT SUM(chemistry) AS "Total chemistry marks obatined" FROM classXmarks;
SELECT SUM(physics) AS "Total physiscs marks obatined" FROM classXmarks;
SELECT SUM(english) AS "Total english marks obatined" FROM classXmarks;
