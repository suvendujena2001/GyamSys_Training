-- Users Table
CREATE TABLE Users (
    UserId INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    PasswordHash NVARCHAR(255) NOT NULL,
    CreatedAt DATETIME2 DEFAULT GETDATE(),
    CreatedBy NVARCHAR(100) DEFAULT SUSER_SNAME(),
    UpdatedAt DATETIME2,
    UpdatedBy NVARCHAR(100)
);

-- Recipes Table
CREATE TABLE Recipes (
    RecipeId INT PRIMARY KEY IDENTITY(1,1),
    UserId INT NOT NULL,
    RecipeName NVARCHAR(255) NOT NULL,
    Instructions NVARCHAR(MAX),
    CookingTime INT,
    CreatedAt DATETIME2 DEFAULT GETDATE(),
    CreatedBy NVARCHAR(100) DEFAULT SUSER_SNAME(),
    UpdatedAt DATETIME2,
    UpdatedBy NVARCHAR(100),
    FOREIGN KEY (UserId) REFERENCES Users(UserId)
);

-- Ingredients Table
CREATE TABLE Ingredients (
    IngredientId INT PRIMARY KEY IDENTITY(1,1),
    RecipeId INT NOT NULL,
    IngredientName NVARCHAR(255) NOT NULL,
    Quantity NVARCHAR(50),
    CreatedAt DATETIME2 DEFAULT GETDATE(),
    CreatedBy NVARCHAR(100) DEFAULT SUSER_SNAME(),
    UpdatedAt DATETIME2,
    UpdatedBy NVARCHAR(100),
    FOREIGN KEY (RecipeId) REFERENCES Recipes(RecipeId)
);

-- Categories Table
CREATE TABLE Categories (
    CategoryId INT PRIMARY KEY IDENTITY(1,1),
    CategoryName NVARCHAR(100) NOT NULL,
    CreatedAt DATETIME2 DEFAULT GETDATE(),
    CreatedBy NVARCHAR(100) DEFAULT SUSER_SNAME(),
    UpdatedAt DATETIME2,
    UpdatedBy NVARCHAR(100)
);

-- RecipeCategories Table (Many-to-Many Relationship)
CREATE TABLE RecipeCategories (
    RecipeId INT NOT NULL,
    CategoryId INT NOT NULL,
    CreatedAt DATETIME2 DEFAULT GETDATE(),
    CreatedBy NVARCHAR(100) DEFAULT SUSER_SNAME(),
    PRIMARY KEY (RecipeId, CategoryId),
    FOREIGN KEY (RecipeId) REFERENCES Recipes(RecipeId),
    FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId)
);

-- Shopping Lists Table
CREATE TABLE ShoppingLists (
    ShoppingListId INT PRIMARY KEY IDENTITY(1,1),
    UserId INT NOT NULL,
    ShoppingListName NVARCHAR(255) NOT NULL,
    CreatedAt DATETIME2 DEFAULT GETDATE(),
    CreatedBy NVARCHAR(100) DEFAULT SUSER_SNAME(),
    UpdatedAt DATETIME2,
    UpdatedBy NVARCHAR(100),
    FOREIGN KEY (UserId) REFERENCES Users(UserId)
);

-- ShoppingListItems Table (Many-to-Many Relationship)
CREATE TABLE ShoppingListItems (
    ShoppingListId INT NOT NULL,
    RecipeId INT NOT NULL,
    Quantity INT,
    CreatedAt DATETIME2 DEFAULT GETDATE(),
    CreatedBy NVARCHAR(100) DEFAULT SUSER_SNAME(),
    PRIMARY KEY (ShoppingListId, RecipeId),
    FOREIGN KEY (ShoppingListId) REFERENCES ShoppingLists(ShoppingListId),
    FOREIGN KEY (RecipeId) REFERENCES Recipes(RecipeId)
);
