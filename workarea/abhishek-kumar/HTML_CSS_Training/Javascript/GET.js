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





///ASSIGNMENT OF DATE 13-02-2024

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

var object={};
object.name='abhishek';
object.id=1;
object.salary=25000;
var newarr=[object];
newarr.push(object);


var object2={}

object2.name='aditya';
object2.id=2;
object2.salary=40000;

console.log(object2);

newarr.push(object2)

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

//spread operator
let fruits = ["apple" , "mango" , "geapese"];
let veg = ["pot", "radsih" , "onion"];
let mixed = [...fruits , ...veg];
console.log(mixed);

let mix = [...fruits];
console.log(mix);

//map function
const num = [1,2,3,4,5];
const squares = num.map(square);
const cubes = num.map(cube);

console.log(squares);
console.log(cubes);
console.log(num);


function square(element){ 
    return Math.pow(element,2)

}

function cube(element){
    return Math.pow(element,3)
    
}


// inheritance
class Animal{
 alive = true;
 eat(){
    console.log(`This ${this.name} is eating`);

 }
 sleep(){
    console.log(`This ${this.name} is sleeping`);
 }
}
class Rabbit extends Animal{
    name = "rabbit";
}
class Fish extends Animal{
    name ="fish";
}

const rabbit = new Rabbit();
const fish = new Fish();
rabbit.eat();
rabbit.sleep();
 
// destructuring 

let a =1 ;
let b = 2 ;
[a,b] = [b,a];
console.log(a);
console.log(b);

function display({name , age , job}){
    console.log(`name : ${name}`);
    console.log(`age ${age}`);
    console.log(`job: ${job}`);
}

const person1 = {
    name :"Abhishek",
    age:22,
    job :"intern",
}

const person2 = {
    name :"Aditya ",
    age:22,
   
}

display(person1);

//closure

function createCounter(){
    let count = 0;
    function inc (){
        count++;
        console.log(`Count increased to ${count}`);
    }

    function getCount(){
        return count;
    }
    return {inc , getCount};
}

const counter = createCounter();
counter.inc();
counter.inc();

console.log(`The current count is ${counter.getCount()}`);

//eventlistener

const mybox = document.getElementById("mybox");
mybox.addEventListener("click", function(event){
    event.target.style.backgroundColor = "tomato";
    event.target.textContent = "OUCH 🤕";
});

mybox.addEventListener("mouseover", event => {
    event.target.style.backgroundColor = "yellow";
    event.target.textContent = "Don't do it 😲";
});

mybox.addEventListener("mouseout", event => {
    event.target.style.backgroundColor = "lightgreen";
    event.target.textContent = "Click Me 😉";
});

//PROMISES
function walkdog(){
    return new Promise((resolve , reject) =>{
        setTimeout(() => {
            const dogwalked = true;
            if(dogwalked){
                resolve("You walk the dog 🐕");
            }
            else{
                reject("You didnt walk the dog");
            }
        }, 1500);
    })
}
function cleanKitchen(){
    return new Promise((resolve , reject) =>{
        setTimeout(() => {
            const kitchenclean = true;
            if(kitchenclean){
                resolve("You cleaned the kitchen");
            }
            else{
                reject("You didnt cleaned the kitchen");
            }
        }, 2500);
    })
}
function takeOutTrash(){
    return new Promise((resolve , reject) =>{
        setTimeout(() => {
            const trash =false;
            if(trash){
                resolve("You cleaned the trash");
            }
            else{
                reject("You didnt cleaned the tarsh");
            }
        }, 500);
    })
}

walkdog().then(value => {console.log(value); return cleanKitchen()})
        .then(value => {console.log(value); return takeOutTrash()})
        .then(value => {console.log(value); console.log("You finished all the chorses")})
        .catch(error => console.error(error));