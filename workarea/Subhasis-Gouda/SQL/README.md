## Here you can find my sql practice queries.

---

### Some syntax of SQL


| TASK | SYNTAX|
|------|-------|
| TO CREATE A DATABASE | CREATE DATABASE Database_name; |
| TO USE EXISTING DATABASE | USE Datbase_name; |
| TO CREATE A TABLE | CREATE TABLE Table_name (Column_name Data_Type Key_Type [NULL/NOT NULL], ... ); |
| TO CREATE A TABLE FROM AN EXISTING TABLE |  CREATE TABLE Table_Name AS SELECT * FROM EMPLOYEE ( EXISTING TABLE NAME ); |
| TO ONLY COPY THE STRUCTURE OF THE TABLE | CREATE TABLE Table_Name AS SELECT * FROM Employee WHERE 1=2; ( 1=2 RETURNS nothing ) |
|