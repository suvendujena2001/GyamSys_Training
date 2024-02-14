// Example of call by value
function modifyValue(value) {
    value = value * 2;
    console.log("Inside function:", value); // Output: Inside function: 20
}

let num = 10;
modifyValue(num);
console.log("Outside function:", num); // Output: Outside function: 10

// Example of call by reference
function modifyObject(obj) {
    obj.prop = "modified";
    console.log("Inside function:", obj); // Output: Inside function: { prop: 'modified' }
}

let myObject = { prop: "original" };
modifyObject(myObject);
console.log("Outside function:", myObject); // Output: Outside function: { prop: 'modified' }
