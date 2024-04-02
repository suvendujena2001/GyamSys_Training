// Example of call by value
let num1 = 10;

function increment(num) {
  num++;
}

increment(num1);
console.log(num1); // Output: 10 (unchanged)


// Example of call by reference
let obj = { value: 10 };

function modifyObject(obj) {
  obj.value = 20;
}

modifyObject(obj);
console.log(obj.value); // Output: 20 (changed)

