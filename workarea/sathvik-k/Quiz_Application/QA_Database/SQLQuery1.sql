-- Create User table
CREATE TABLE Users (
    user_id INT PRIMARY KEY,
    username NVARCHAR(50) NOT NULL,
    password NVARCHAR(255) NOT NULL, -- Encrypted password
    email NVARCHAR(100) NOT NULL,
    -- Other relevant user information
    created_at DATETIME2(7) GENERATED ALWAYS AS ROW START,
    deleted_at DATETIME2(7) GENERATED ALWAYS AS ROW END,
    PERIOD FOR SYSTEM_TIME (created_at, deleted_at)
)
WITH (SYSTEM_VERSIONING = ON);

-- Create Category table
CREATE TABLE Categories (
    category_id INT PRIMARY KEY,
    category_name NVARCHAR(50),
    -- Other relevant category information
    created_at DATETIME2(7) GENERATED ALWAYS AS ROW START,
    deleted_at DATETIME2(7) GENERATED ALWAYS AS ROW END,
    PERIOD FOR SYSTEM_TIME (created_at, deleted_at)
)
WITH (SYSTEM_VERSIONING = ON);

-- Create Quiz table
CREATE TABLE Quizzes (
    quiz_id INT PRIMARY KEY,
    quiz_title NVARCHAR(100) NOT NULL,
    administrator_id INT FOREIGN KEY REFERENCES Users(user_id),
    category_id INT FOREIGN KEY REFERENCES Categories(category_id),
    time_limit INT,
    -- Other relevant quiz information
    created_at DATETIME2(7) GENERATED ALWAYS AS ROW START,
    deleted_at DATETIME2(7) GENERATED ALWAYS AS ROW END,
    PERIOD FOR SYSTEM_TIME (created_at, deleted_at)
)
WITH (SYSTEM_VERSIONING = ON);

-- Create Question table
CREATE TABLE Questions (
    question_id INT PRIMARY KEY,
    quiz_id INT FOREIGN KEY REFERENCES Quizzes(quiz_id),
    question_text NVARCHAR(MAX) NOT NULL,
    question_type NVARCHAR(50),
    -- Other relevant question information
    created_at DATETIME2(7) GENERATED ALWAYS AS ROW START,
    deleted_at DATETIME2(7) GENERATED ALWAYS AS ROW END,
    PERIOD FOR SYSTEM_TIME (created_at, deleted_at)
)
WITH (SYSTEM_VERSIONING = ON);

-- Create Answer table
CREATE TABLE Answers (
    answer_id INT PRIMARY KEY,
    question_id INT FOREIGN KEY REFERENCES Questions(question_id),
    answer_text NVARCHAR(MAX) NOT NULL,
    is_correct BIT,
    -- Other relevant answer information
    created_at DATETIME2(7) GENERATED ALWAYS AS ROW START,
    deleted_at DATETIME2(7) GENERATED ALWAYS AS ROW END,
    PERIOD FOR SYSTEM_TIME (created_at, deleted_at)
)
WITH (SYSTEM_VERSIONING = ON);

-- Create Quiz_Attempt table
CREATE TABLE Quiz_Attempts (
    attempt_id INT PRIMARY KEY,
    quiz_id INT FOREIGN KEY REFERENCES Quizzes(quiz_id),
    user_id INT FOREIGN KEY REFERENCES Users(user_id),
    start_time DATETIME,
    end_time DATETIME,
    score INT,
    -- Other relevant attempt information
    created_at DATETIME2(7) GENERATED ALWAYS AS ROW START,
    deleted_at DATETIME2(7) GENERATED ALWAYS AS ROW END,
    PERIOD FOR SYSTEM_TIME (created_at, deleted_at)
)
WITH (SYSTEM_VERSIONING = ON);

-- Create Quiz_Attempt_Detail table
CREATE TABLE Quiz_Attempt_Details (
    detail_id INT PRIMARY KEY,
    attempt_id INT FOREIGN KEY REFERENCES Quiz_Attempts(attempt_id),
    question_id INT FOREIGN KEY REFERENCES Questions(question_id),
    user_answer NVARCHAR(MAX),
    is_correct BIT,
    -- Other relevant attempt detail information
    created_at DATETIME2(7) GENERATED ALWAYS AS ROW START,
    deleted_at DATETIME2(7) GENERATED ALWAYS AS ROW END,
    PERIOD FOR SYSTEM_TIME (created_at, deleted_at)
)
WITH (SYSTEM_VERSIONING = ON);



-- Create Leaderboard table
CREATE TABLE Leaderboard (
    leaderboard_id INT PRIMARY KEY,
    quiz_id INT FOREIGN KEY REFERENCES Quizzes(quiz_id),
    user_id INT FOREIGN KEY REFERENCES Users(user_id),
    score INT,
    -- Other relevant leaderboard information
    created_at DATETIME2(7) GENERATED ALWAYS AS ROW START,
    deleted_at DATETIME2(7) GENERATED ALWAYS AS ROW END,
    PERIOD FOR SYSTEM_TIME (created_at, deleted_at)
)
WITH (SYSTEM_VERSIONING = ON);
