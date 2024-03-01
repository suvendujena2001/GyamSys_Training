create table mothers(
mot_name varchar(30), mot_childno int, chi_name varchar(30), isdaycare bit);

insert into mothers values
('KUSUM', 1, 'HYUNG', 0),
(
'NAYANIKA', 1, 'KIRTAN', 1),
(
'MARTHA', 3, 'MALISHKA', 0),

('SNEHALI', 2, 'TONTAWAN', 1);

SELECT * FROM mothers 
WHERE isdaycare =0;

SELECT * FROM mothers 
WHERE mot_childno BETWEEN 1 AND 2;

SELECT * FROM mothers 
WHERE isdaycare =0 AND mot_childno BETWEEN 1 AND 2;

SELECT chi_name  FROM mothers
GROUP BY chi_name
 
 select * from mothers
 order by mot_childno desc


 SELECT COUNT(mot_childno) as 'no of offsprings' 
FROM mothers
GROUP BY mot_childno
HAVING COUNT(mot_childno) >=2;