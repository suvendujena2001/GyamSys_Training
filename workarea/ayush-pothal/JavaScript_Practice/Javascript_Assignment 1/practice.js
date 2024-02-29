
//call-stack queue
console.log("1");
console.log("2");
function func()
{
    console.log("3");
}
setTimeout(func,1);
console.log("4");

//call by value
var a=10;
var b=a;
b=5;
console.log("a="+a);
console.log("b="+b);


//call by reference
var arr1=["a","b","c"];
var arr2=arr1;
arr2.push("c");
console.log(arr1);
console.log(arr2);

//filter and map function
var arr3=[11, 21, 31, 41, 51];
var arr4=arr3.filter(x=>x>20);

var arr5=arr3.map(x=>x-1);

console.log(arr3);
console.log(arr4);
console.log(arr5);

//onclick event
function func1()
{
    document.getElementById("demo1").innerText="Hello";
}

//ondblclick event
function func2()
{
    document.getElementById("demo2").innerHTML="Bye";
}

//onmouseover and onmouseout event
function bigImg(x) {
  x.style.height = "64px";
  x.style.width = "64px";
  }

  function normalImg(x) {
  x.style.height = "32px";
  x.style.width = "32px";
  }

  //onkeyup event
  function func3() {
  let x = document.getElementById("fname");
  x.value = x.value.toUpperCase();
 }