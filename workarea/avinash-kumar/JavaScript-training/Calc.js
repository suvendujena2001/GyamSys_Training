

function solve(val){
    var v=document.getElementById('res');
    v.value+=val;
}

function result(){
    var num1 = document.getElementById('res').value;
   var num2 = eval(num1);
   document.getElementById('res').value = num2;
   document.getElementById('result-container').innerHTML=`
   <h2>Result: ${num2}</h2>
   `
}


function Clear(){
    var ev = document.getElementById('res');
         ev.value = '';
}

function back(){
    var ev = document.getElementById('res');
         ev.value = ev.value.slice(0,-1);
}

alert("Calculate Your something")


let arr=[10,20,30,30,50]

console.log(arr);

//copy by reference
let copyarr=arr;
copyarr.push(40)
console.log(arr);
console.log(copyarr);

//copy by value
let anothercopyarr=Array.from(arr)
anothercopyarr.push(60);
console.log(anothercopyarr)
let a=20;
let b=30;
console.log(a,b)
console.log(b);
a=b;
console.log(a,b)


setTimeout(function() {
   console.log("i am inside function");
},10000)

