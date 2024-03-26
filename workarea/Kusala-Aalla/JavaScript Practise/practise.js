//call-stack

function f1(){
    console.log('hi');
}
function f2(){
    f1();
    console.log('hello');
}
f2();
 
//call by value

let a = 5;
let b;
b = a;
a = 3;
console.log(a);
console.log(b);

//call by reference

var arr1=["a","b","c","d"];
var arr2=arr1;
let arr2=x;
console.log('arr2');
console.log('arr1');

//map function

const number = [5, 10, 15, 20, 25, 30]; 
  
const multipliedNumber =  
    numbers.map(num => num * 3); 
console.log(multipliedNumber);

//filter function

const numbers = [5, 10, 15, 20, 25, 30]; 
  
const numbersGreaterThan20 =  
    numbers.filter(num => num > 20); 
  
console.log(numbers>20);