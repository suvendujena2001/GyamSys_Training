console.log("hello day-4");
let fruits = ["Banana", "Orange", "Apple", "Mango"];
console.log("fruits");
console.log(fruits);
fruits.pop();
console.log("after pop");
console.log(fruits);
fruits.push("Kiwi");
console.log("after push");
console.log(fruits);
fruits.shift();
console.log("after push");
console.log(fruits);
delete fruits[0];
console.log("after delete");
console.log(fruits);
const myGirls = ["Cecilie", "Lone"];
console.log(myGirls);
const myBoys = ["Emil", "Tobias", "Linus"];
console.log(myBoys);
const myChildren = myGirls.concat(myBoys);
console.log("after concat of mygirls and myboys");
console.log(myChildren);
console.log("const");
const cars = ["Saab", "Volvo", "BMW"];
// cars = ["Toyota", "Volvo", "Audi"];//error

cars[0] = "Toyota";

cars.push("Audi");
const numbers = [45, 4, 9, 16, 25];

let txt = "";
for (let x in numbers) {
  txt += numbers[x];
}
console.log(txt);

const person = {
  firstName: "John",
  lastName: "Doe",
  id: 5566,
  fullName: function () {
    return this.firstName + " " + this.lastName;
  }
};

console.log("person object is ");
console.log(person);

console.log("lastName of person is");
console.log(person.lastName);
console.log("or the other way is person['lastName']");
console.log(person["lastName"]);
console.log("person full name is");
console.log(person.fullName());

//maps
const mapfruits = new Map();

mapfruits.set("apples", 500);
mapfruits.set("bananas", 300);
mapfruits.set("oranges", 200);

console.log(mapfruits);
console.log("size of map");
console.log(mapfruits.size);
// simillarly has and delete
console.log("if you the check the type then ");
console.log(typeof mapfruits);
//block scope
// Variables declared inside a { } block cannot be accessed from outside the block:
{
  let x = 2;
}
// x can NOT be used here
{
  var x = 2;
}
// x CAN be used here

//local scope
// Variables declared within a JavaScript function, are LOCAL to the function:

// code here can NOT use carName

function myFunction() {
    let carName = "Volvo";
    // code here CAN use carName
  }
  
  // code here can NOT use carName

//Global JavaScript Variables
//A global variable has Global Scope:
let carName = "Volvo";
// code here can use carName

function myFunction() {
// code here can also use carName
}
//In "Strict Mode", undeclared variables are not automatically global.

//Global Variables in HTML

var newcarName = "Volvo";
// code here can use window.carName