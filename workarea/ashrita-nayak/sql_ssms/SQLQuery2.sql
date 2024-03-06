CREATE TABLE students (
    stu_rollno INT PRIMARY KEY,
    stu_name VARCHAR(50)
);

CREATE TABLE teachers (
    tea_id INT PRIMARY KEY,
    tea_name VARCHAR(50)
);
INSERT INTO students (stu_rollno , stu_name ) VALUES
(1, 'Ashmita Mittal'),
(2, 'Banku Tripathy'),
(3, 'Champak Gada'),
(4, 'Dhwani Vanushali');

INSERT INTO teachers (tea_id , tea_name) VALUES
(2,'Banku Tripathy'),
(4, 'Champak Gada'),
(5, 'Valak Strongin');


SELECT stu_name FROM students
INTERSECT
SELECT tea_name FROM teachers;
