/*

CREATE TABLE customers (
    customer_id INT PRIMARY KEY,
    customer_name VARCHAR(50)
);

-- Creating the orders table
CREATE TABLE orders (
    order_id INT PRIMARY KEY,
    order_date DATE,
    customer_id INT,
    -- Other columns in the orders table
    FOREIGN KEY (customer_id) REFERENCES customers(customer_id)
);*/

-- Inserting data into the customers table
---INSERT INTO customers (customer_id, customer_name) VALUES (1, 'John Doe'), (2, 'Jane Smith'), (3, 'Bob Johnson');

-- Inserting data into the orders table
---INSERT INTO orders (order_id, order_date, customer_id) VALUES (104, '2024-02-25', 1), (105, '2024-02-26', 2), (106, '2024-02-27', 3);

/*

ALTER TABLE HumanResources.Department ADD Group_code varchar(200); /*Adding column of name Group_code*/

EXEC sp_rename 'HumanResources.Department.Group_code', 'Grp_Code', 'COLUMN'; /*Renaming the column using SP*/



*/

---JOINS CONCEPT
---SELECT * FROM customers JOIN orders ON customers.customer_id = orders.customer_id;

---LEFT JOIN
---SELECT * FROM customers LEFT JOIN orders ON customers.customer_id = orders.customer_id;

---RIGHT JOIN
---SELECT * FROM customers RIGHT JOIN orders ON customers.customer_id = orders.customer_id;

---CROSS JOIN
---SELECT * FROM customers CROSS JOIN orders;





-- Common Table Expression (CTE)

/*WITH CustomerOrders AS (
    SELECT
        customers.customer_id,
        customers.customer_name,
        orders.order_id,
        orders.order_date
    FROM
        customers
    LEFT JOIN
        orders ON customers.customer_id = orders.customer_id
)

-- Query using the CTE
SELECT *
FROM CustomerOrders;

*/

---Constraints on a table
/* CREATE TABLE example_table (
    email VARCHAR(100) UNIQUE,
    phone_number VARCHAR(15) UNIQUE
); */

select * from orders;
