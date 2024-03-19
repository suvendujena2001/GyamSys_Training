var a = 10;
var b = a;
b +=2;
console.log(b);
console.log(a);//call by value (Here the value assigned to "b" derived from "a" changes but the value of "a" remains intact. )
var arr = [1,2,3,4,5];
var arr2 = arr;
arr2.push(6);
console.log(arr2);
console.log(arr);//Call by reference( Even though we pushed an element to arr2 the value of arr also changes as it takes the address as an input rather than taking  the value.)


    setTimeout(myFunction, 3000);

function myFunction() {
  document.getElementById("sync").innerHTML = "I'm not in sync";
}
function clicked(){
    document.getElementById('date').innerHTML=Date();
}
function mouseOver() {
    document.getElementById("mouseover").style.color = "red";
}
function mouseOut() {
    document.getElementById("mouseover").style.color = "black";
}
function swagat(){
    document.getElementById("keyup").style.backgroundColor = "blue";
    

}
function focused(){
    document.getElementById("text").style.backgroundColor = "red";
}
var person1 = {};
person1.name = "Raj";
person1.id = 112;
person1.degree = "b.tech";
person1.status = "busy";
console.log(person1);

var person2 = {};
person2.name = "Ram";
person2.id = 113;
person2.degree = "BBA";
person2.status = "free";
console.log(person2);

var person3 = {};
person3.name = "Rahul";
person3.id = 114;
person3.degree = "B.Sc";
person3.status = "free";
console.log(person3);

List1 = [person1, person2, person3];
var m = List1.filter(e=>e.status=="free");
console.log(m);
console.log(List1);
var dupe=m.map(d=>d.amount=10000);
console.log(m);
console.log(dupe)
console.log(List1);

var arr3 = [1,2,3,4,5,6,7,8]
var x = arr3.filter(x=>x<5);
console.log(x);
console.log(arr3);

var y = arr3.map(x=>x+1);
console.log(y);
console.log(arr3);
var text=["abd","vbsdb","ckhdbch"];
var caps= text.map(function (t) { return  t.toUpperCase();})
console.log(text);
console.log(caps);




