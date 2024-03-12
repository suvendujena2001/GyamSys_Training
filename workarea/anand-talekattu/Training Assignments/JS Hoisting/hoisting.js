console.log(a);  //undefined, calling variable before its declared
var a=10;
console.log(a);  //10, calling variable after it is defined
// console.log(b);  //since b is not defined, its an error
var n = 5;
console.log(square(3));   //9 ,calling function before function declaration
function square(n) {
  var ans = n * n;
  return ans;
}

var square1 = square(n);  
var square2 = square(8);  

console.log(square1)  //25, calling function after function definition
console.log(square2)  //64