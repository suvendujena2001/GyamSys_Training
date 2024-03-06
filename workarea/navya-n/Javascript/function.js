//call by value
function changenum(num){
   num=40;
   return num;
}
let number=10;
changenum(number);
//output:40
console.log(number);
//output:10


//call by reference
function changeobj(obj){
    obj.name="john";
}
let person={name:"jim"}
changeobj(person);
console.log(person.name);
//output:john
console.log(person);
//output:{name:'john'}
