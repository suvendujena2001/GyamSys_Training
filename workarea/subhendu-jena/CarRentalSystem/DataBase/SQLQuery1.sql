-- Vehicles table
CREATE TABLE Vehicles (
    vehicle_id INT PRIMARY KEY,
    make VARCHAR(50),
    model VARCHAR(50),
    year INT,
    color VARCHAR(50),
    mileage DECIMAL(10, 2),
    rental_rate_per_hour DECIMAL(10, 2),
    rental_rate_per_day DECIMAL(10, 2),
    rental_rate_per_week DECIMAL(10, 2),
    availability_status VARCHAR(20),

	CreatedDate Datetime,
    CreatedBy INT,
    UpdatedDate Datetime,
    UpdatedBy VARCHAR(50)
);

-- Users table
CREATE TABLE Users (
    user_id INT PRIMARY KEY,
    username VARCHAR(50),
    password VARCHAR(255),
    email VARCHAR(100),
    full_name VARCHAR(100),
    phone_number VARCHAR(20),
    address VARCHAR(255),
    rental_history VARCHAR(MAX),

	CreatedDate Datetime,
    CreatedBy INT,
    UpdatedDate Datetime,
    UpdatedBy VARCHAR(50)
);

-- Reservations table
CREATE TABLE Reservations (
    reservation_id INT PRIMARY KEY,
    user_id INT,
    vehicle_id INT,
    start_date_time DATETIME,
    end_date_time DATETIME,
    total_cost DECIMAL(10, 2),
    status VARCHAR(20),
    FOREIGN KEY (user_id) REFERENCES Users(user_id),
    FOREIGN KEY (vehicle_id) REFERENCES Vehicles(vehicle_id),

	CreatedDate Datetime,
    CreatedBy INT,
    UpdatedDate Datetime,
    UpdatedBy VARCHAR(50)
);

-- Payments table
CREATE TABLE Payments (
    payment_id INT PRIMARY KEY,
    reservation_id INT,
    payment_date DATETIME,
    amount DECIMAL(10, 2),
    payment_method VARCHAR(50),
    FOREIGN KEY (reservation_id) REFERENCES Reservations(reservation_id),

	CreatedDate Datetime,
    CreatedBy INT,
    UpdatedDate Datetime,
    UpdatedBy VARCHAR(50)
);

-- Maintenance table
CREATE TABLE Maintenance (
    maintenance_id INT PRIMARY KEY,
    vehicle_id INT,
    maintenance_date DATETIME,
    description VARCHAR(MAX),
    cost DECIMAL(10, 2),
    FOREIGN KEY (vehicle_id) REFERENCES Vehicles(vehicle_id),

	CreatedDate Datetime,
    CreatedBy INT,
    UpdatedDate Datetime,
    UpdatedBy VARCHAR(50)
);

-- Customer Support table
CREATE TABLE CustomerSupport (
    support_id INT PRIMARY KEY,
    user_id INT,
    timestamp DATETIME,
    channel VARCHAR(20),
    message VARCHAR(MAX),
    FOREIGN KEY (user_id) REFERENCES Users(user_id),

	CreatedDate Datetime,
    CreatedBy INT,
    UpdatedDate Datetime,
    UpdatedBy VARCHAR(50)
);


CREATE TABLE Roles (
    role_id INT PRIMARY KEY,
    role_name VARCHAR(50)
);

ALTER TABLE Users Add role_id INT Foreign Key References Roles(role_id);

ALTER TABLE Roles
ADD CreatedDate DATETIME,
    CreatedBy INT,
    UpdatedDate DATETIME,
    UpdatedBy VARCHAR(50);
