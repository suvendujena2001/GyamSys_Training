-- User Table
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(100) NOT NULL, -- Passwords should be hashed and salted for security
    Email NVARCHAR(100) NOT NULL,
    UserType NVARCHAR(20) CHECK(UserType IN ('admin', 'user')), -- UserType column for admin or user
    CreatedAt DATETIME2 DEFAULT GETDATE(),
    UpdatedAt DATETIME2 DEFAULT GETDATE(),
    DeletedAt DATETIME2 NULL
);

-- Quiz Table
CREATE TABLE Quizzes (
    QuizID INT PRIMARY KEY IDENTITY(1,1),
    QuizName NVARCHAR(100) NOT NULL,
    Topic NVARCHAR(50) NOT NULL,
    CreatedBy INT FOREIGN KEY REFERENCES Users(UserID),
    CreatedAt DATETIME2 DEFAULT GETDATE(),
    UpdatedAt DATETIME2 DEFAULT GETDATE(),
    DeletedAt DATETIME2 NULL
);

-- Question Table
CREATE TABLE Questions (
    QuestionID INT PRIMARY KEY IDENTITY(1,1),
    QuestionText NVARCHAR(MAX) NOT NULL,
    QuestionType NVARCHAR(20) NOT NULL, -- For multiple choice, true/false, fill-in-the-blank, etc.
    CreatedBy INT FOREIGN KEY REFERENCES Users(UserID),
    CreatedAt DATETIME2 DEFAULT GETDATE(),
    UpdatedAt DATETIME2 DEFAULT GETDATE(),
    DeletedAt DATETIME2 NULL
);

-- QuizResult Table
CREATE TABLE QuizResults (
    ResultID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    QuizID INT FOREIGN KEY REFERENCES Quizzes(QuizID),
    Score INT NOT NULL,
    AttemptedAt DATETIME2 DEFAULT GETDATE(),
    CONSTRAINT FK_User_Quiz_Result UNIQUE (UserID, QuizID) -- Ensure each user can have only one attempt for each quiz
);

-- Audit Tables
CREATE TABLE UsersAudit (
    AuditID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT,
    Action NVARCHAR(20),
    Timestamp DATETIME2 DEFAULT GETDATE()
);

CREATE TABLE QuizzesAudit (
    AuditID INT PRIMARY KEY IDENTITY(1,1),
    QuizID INT,
    Action NVARCHAR(20),
    Timestamp DATETIME2 DEFAULT GETDATE()
);

CREATE TABLE QuestionsAudit (
    AuditID INT PRIMARY KEY IDENTITY(1,1),
    QuestionID INT,
    Action NVARCHAR(20),
    Timestamp DATETIME2 DEFAULT GETDATE()
);

CREATE TABLE QuizResultsAudit (
    AuditID INT PRIMARY KEY IDENTITY(1,1),
    ResultID INT,
    Action NVARCHAR(20),
    Timestamp DATETIME2 DEFAULT GETDATE()
);
