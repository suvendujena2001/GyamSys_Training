// Boolean Values
// A boolean type is declared with the bool keyword and can only take the values true or false:

// Example
bool isCSharpFun = true;
bool isFishTasty = false;
Console.WriteLine(isCSharpFun);   // Outputs True
Console.WriteLine(isFishTasty);   // Outputs False

// Boolean Expression
// A Boolean expression returns a boolean value: True or False, by comparing values/variables.

// This is useful to build logic, and find answers.

// For example, you can use a comparison operator, such as the greater than (>) operator to find out if an expression (or a variable) is true:

// Example
int x = 10;
int y = 9;
Console.WriteLine(x > y); // returns True, because 10 is higher than 9

// Or even easier:

// Example
Console.WriteLine(10 > 9); // returns True, because 10 is higher than 9

// In the examples below, we use the equal to (==) operator to evaluate an expression:

// Example
int x = 10;
Console.WriteLine(x == 10); // returns True, because the value of x is equal to 10

// Example
Console.WriteLine(10 == 15); // returns False, because 10 is not equal to 15

// Real Life Example
// Let's think of a "real life example" where we need to find out if a person is old enough to vote.

// In the example below, we use the >= comparison operator to find out if the age (25) is greater than OR equal to the voting age limit, which is set to 18:

// Example
int myAge = 25;
int votingAge = 18;
Console.WriteLine(myAge >= votingAge);

// Example
Output "Old enough to vote!" if myAge is greater than or equal to 18. Otherwise output "Not old enough to vote.":

int myAge = 25;
int votingAge = 18;

if (myAge >= votingAge) 
{
  Console.WriteLine("Old enough to vote!");
} 
else 
{
  Console.WriteLine("Not old enough to vote.");
}
