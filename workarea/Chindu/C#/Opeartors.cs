int a = 10;
int b = 5;

// Arithmetic Operators
int sum = a + b;       // 15
int difference = a - b;// 5
int product = a * b;   // 50
int quotient = a / b;  // 2
int remainder = a % b; // 0

// Assignment Operators
a += b; // Equivalent to: a = a + b;

// Comparison Operators
bool isEqual = (a == b);   // false
bool isGreater = (a > b);  // true

// Logical Operators
bool result = (a > b) && (a != 0); // true

// Increment and Decrement Operators
a++; // Increment a by 1
b--; // Decrement b by 1

// Conditional Operator
int max = (a > b) ? a : b; // max will hold the maximum of a and b

// Bitwise Operators
int bitwiseAnd = a & b;
int bitwiseOr = a | b;

Console.WriteLine($"Arithmetic: {sum}, {difference}, {product}, {quotient}, {remainder}");
Console.WriteLine($"Assignment: {a}");
Console.WriteLine($"Comparison: {isEqual}, {isGreater}");
Console.WriteLine($"Logical: {result}");
Console.WriteLine($"Increment/Decrement: {a}, {b}");
Console.WriteLine($"Conditional: {max}");
Console.WriteLine($"Bitwise: {bitwiseAnd}, {bitwiseOr}");

