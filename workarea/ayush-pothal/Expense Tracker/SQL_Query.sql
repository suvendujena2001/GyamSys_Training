CREATE TABLE Users (
    UserId INT PRIMARY KEY,
    Username VARCHAR(50) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    PasswordHash VARCHAR(255) NOT NULL,
    RegistrationDate DATE NOT NULL,
    UserType VARCHAR(20) NOT NULL,
    Active BIT NOT NULL,
	CreatedDate Datetime,
    CreatedBy INT,
    UpdatedDate Datetime,
    UpdatedBy VARCHAR(50)
);
CREATE TABLE Expenses (
    ExpenseId INT PRIMARY KEY,
    UserId INT FOREIGN KEY REFERENCES Users(UserId),
    CategoryName VARCHAR(50) NOT NULL,
    Date DATE NOT NULL,
    Amount DECIMAL(10, 2) NOT NULL,
    Description VARCHAR(255),
    PaymentMethod VARCHAR(50),
	CreatedDate Datetime,
    CreatedBy INT,
    UpdatedDate Datetime,
    UpdatedBy VARCHAR(50)
);

CREATE TABLE Budgets (
    BudgetId INT PRIMARY KEY,
    UserId INT FOREIGN KEY REFERENCES Users(UserId),
    CategoryName VARCHAR(50) NOT NULL,
    BudgetType VARCHAR(20) NOT NULL,
    BudgetAmount DECIMAL(10, 2) NOT NULL,
	CreatedDate Datetime,
    CreatedBy INT,
    UpdatedDate Datetime,
    UpdatedBy VARCHAR(50)
);
CREATE TABLE TransactionHistory (
    TransactionId INT PRIMARY KEY,
    UserId INT FOREIGN KEY REFERENCES Users(UserId),
    ExpenseId INT FOREIGN KEY REFERENCES Expenses(ExpenseId),
    TransactionDate DATE NOT NULL,
    TransactionType VARCHAR(50) NOT NULL,
    TransactionDetails VARCHAR(MAX),
	CreatedDate Datetime,
    CreatedBy INT,
    UpdatedDate Datetime,
    UpdatedBy VARCHAR(50)
);
