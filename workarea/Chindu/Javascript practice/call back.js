// Example of a callback function
function greet(name, callback) {
  console.log('Hello, ' + name + '!');
  callback();
}

// Callback function
function sayGoodbye() {
  console.log('Goodbye!');
}

// Calling the greet function with a callback
greet('Alice', sayGoodbye);
