//Assignment 14.02.24

var listIntern =[10,20,30,40];
var fte = [50,60,70,80];


console.log(listIntern.pop());

listIntern.push(100);
console.log(listIntern);
console.log(listIntern.slice(2,3));


 var all =(listIntern.concat(fte));
 console.log(all);

 fte.shift()
 console.log(fte);

 fte.unshift(100)
 console.log(fte);

 var arr=['abhi','avi','adi','abhi'];

 console.log(arr.lastIndexOf('abhi'));
 console.log(arr.indexOf('abhi'));

 function testing(value,i,listIntern){return value>20};

console.log(listIntern.find(testing));

console.log(listIntern.findIndex(testing));

console.log(listIntern.findLastIndex(testing));



let ar=[1,2,3,4,5,6]

console.log(ar);

//call by value
let copyar=Array.from(ar)
copyar.push(60);
console.log(copyar)
let z=100;
let y=1000;
console.log(z,y)
console.log(y);
z=y;
console.log(z,y)

//call by reference
let copyarray=ar;
copyarray.push(40)
console.log(ar);
console.log(copyarray);

///ASSIGNMENT OF DATE 13-02-2024

var object={};
object.name='abhishek';
object.id=1;
object.salary=25000;
var newarr=[object];
newarr.push(object);


var obj2={}

obj2.name='aditya';
obj2.id=2;
obj2.salary=40000;

console.log(obj2);

newarr.push(obj2)

console.log(newarr);

let f=newarr.map(item=>item.contract=1);

console.log(f);

console.log(newarr);


let v=newarr.filter(item=> item.salary>50000);

console.log(v);


function printHi(){
    console.log("Hello");
}
function hi(){
    setTimeout(printHi,2000);
}
function newFun(){
hi();
}

function nf2(){
    newFun();
}

nf2();


