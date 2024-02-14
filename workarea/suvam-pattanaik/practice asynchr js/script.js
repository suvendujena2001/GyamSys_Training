

// // Implementing  asynchronous javascript with use of setTimeout..

setTimeout(myfunction , 3000);

function myfunction() {
    document.querySelector('h3').innerHTML = "I am in Bangalore";

}

// // Implementing call by value 

var a = 5;
var b =a;
b*=3;

console.log(a);
console.log(b);

// implement call by reference

var arr1 = ["a","b","c"];
var arr2 = arr1;
console.log(arr1);
console.log(arr2);

arr2.push("d","e");

console.log(arr1);
console.log(arr2);


function myFunction(element, color) {
    element.style.color = color;
}


function over()
{
    document.getElementById('key').innerHTML = "On mouseover event has occured";
}

function out(){
    document.getElementById('key').innerHTML ="Onmouse out event has occured";
}

function myFunction(){
    let x = document.getElementById("fname");
    x.value = x.value.toUpperCase();
}



//implementing onkeyup and onkeydown


function onkeyupfunction() {
    document.getElementById("demo").style.backgroundColor = "yellow";
}

function onkeydownfunction(){
    document.getElementById("demo").style.background = "orange";
}

function onkeypressfunction(){
    document.getElementById("demo").style.backgroundColor="blue";
}

//on focus and onblur 

function onfocusfunction() {
    document.getElementById("fname").style.backgroundColor = "red";
  }
  function onblurfunction(){
      document.getElementById("fname").style.backgroundColor ="yellow";
  
  }

  //implementing map and filter method with help of object creation

  let employeees =[
    {name:"Suvam" , department:"CSE"},
    {name:"swagat" , department:"CSE"},
    {name:"subhasish" , department:"ECE"},
    {name:"ayush",department:"IT"},
  ];

  let output = employeees.filter(emp => emp.department =="CSE");

  console.log(output);

 let newproperty =  employeees.map(d => d.qualification = "B.Tech");

 console.log(newproperty);
 console.log(employeees);