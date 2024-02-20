create database KP;
use KP;
CREATE TABLE student (
    student_id INT PRIMARY KEY,
    first_name VARCHAR(50),
    last_name VARCHAR(50),
    date_of_birth DATE,
    email VARCHAR(100),
    phone_number VARCHAR(20),
    address VARCHAR(255)
);
select * from student;
INSERT INTO student (student_id, first_name, last_name, date_of_birth, email, phone_number, address)
VALUES
    (1, 'John', 'Doe', '2000-05-15', 'john.doe@example.com', '123-456-7890', '123 Main St, City, Country'),
    (2, 'Jane', 'Smith', '2001-08-20', 'jane.smith@example.com', '987-654-3210', '456 Elm St, Town, Country'),
    (3, 'Michael', 'Johnson', '1999-12-10', 'michael.johnson@example.com', '555-123-4567', '789 Oak St, Village, Country'),
    (4, 'Emily', 'Brown', '2002-03-25', 'emily.brown@example.com', '222-333-4444', '321 Pine St, City, Country'),
    (5, 'William', 'Taylor', '2000-11-05', 'william.taylor@example.com', '999-888-7777', '654 Cedar St, Town, Country'),
    (6, 'Olivia', 'Martinez', '2001-07-12', 'olivia.martinez@example.com', '777-666-5555', '987 Maple St, Village, Country'),
    (7, 'James', 'Anderson', '2000-09-30', 'james.anderson@example.com', '111-222-3333', '753 Birch St, City, Country'),
    (8, 'Sophia', 'Garcia', '2001-04-18', 'sophia.garcia@example.com', '444-555-6666', '852 Walnut St, Town, Country'),
    (9, 'Alexander', 'Lopez', '2000-02-08', 'alexander.lopez@example.com', '666-777-8888', '369 Spruce St, Village, Country'),
    (10, 'Charlotte', 'Hernandez', '2002-06-22', 'charlotte.hernandez@example.com', '000-999-1111', '159 Oak St, City, Country'),
    (11, 'Daniel', 'Smith', '1998-10-17', 'daniel.smith@example.com', '777-888-9999', '258 Elm St, Town, Country'),
    (12, 'Amelia', 'Gonzalez', '2001-01-03', 'amelia.gonzalez@example.com', '333-444-5555', '753 Pine St, Village, Country'),
    (13, 'Benjamin', 'Perez', '1999-07-28', 'benjamin.perez@example.com', '999-000-1111', '456 Cedar St, City, Country'),
    (14, 'Mia', 'Wilson', '2000-04-14', 'mia.wilson@example.com', '111-222-3333', '951 Maple St, Town, Country'),
    (15, 'Ethan', 'Rodriguez', '2002-09-09', 'ethan.rodriguez@example.com', '888-777-6666', '357 Oak St, Village, Country'),
    (16, 'Isabella', 'Torres', '2001-12-31', 'isabella.torres@example.com', '444-555-6666', '852 Birch St, City, Country'),
    (17, 'Aiden', 'Nguyen', '2000-08-08', 'aiden.nguyen@example.com', '666-555-4444', '369 Pine St, Town, Country'),
    (18, 'Evelyn', 'Gomez', '1998-03-07', 'evelyn.gomez@example.com', '777-888-9999', '159 Cedar St, Village, Country'),
    (19, 'Jacob', 'Hernandez', '2001-06-15', 'jacob.hernandez@example.com', '222-333-4444', '258 Elm St, City, Country'),
    (20, 'Abigail', 'Kim', '2002-02-25', 'abigail.kim@example.com', '333-444-5555', '753 Maple St, Town, Country');

select * from student where  phone_number = '333-444-5555';
select * from student where  first_name = 'Jacob';
select * from student where  student_id >= 10;
alter table student 
ADD Age int;
alter table student
DROP COLUMN Age;

exec sp_rename 'student.student_id','ID' ;

select * from student;


alter table student
ADD stdept varchar(40);


UPDATE student
SET email = 'jking@test.com'
WHERE first_name = 'Abigail';

DELETE FROM student WHERE first_name = 'Abigail';