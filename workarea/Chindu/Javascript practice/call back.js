// Function that takes two numbers and a callback function to perform an operation on them
function calculate(num1, num2, operationCallback) {
    const result = operationCallback(num1, num2);
    console.log("Result:", result);
}

// Callback function to add two numbers
function add(a, b) {
    return a + b;
}

// Callback function to multiply two numbers
function multiply(a, b) {
    return a * b;
}

// Using the calculate function with different callback functions
calculate(5, 3, add); // Output: Result: 8
calculate(5, 3, multiply); // Output: Result: 15
