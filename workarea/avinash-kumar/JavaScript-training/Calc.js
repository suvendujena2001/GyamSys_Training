
alert("Calculate Your something")


let arr=[10,20,30,30,50]

console.log(arr);

//call by reference
let copyarr=arr;
copyarr.push(40)
console.log(arr);
console.log(copyarr);

//call by value
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

function func3(){
    console.log("key is pressed");
}

function func4(){
    let d=document.getElementById('color-change');
    d.style.color='red';
}


/////ASSIGNMENT OF DATE 13-02-2024

var obj={};
obj.name='avinash';
obj.id=1;
obj.salary=25000;
var newarr=[obj,obj];
newarr.push(obj);
newarr.push(obj);

var obj2={}

obj2.name='rahul';
obj2.id=2;
obj2.salary=35000;

console.log(obj);

newarr.push(obj2)

console.log(newarr);

let f=newarr.map(item=>item.contract=1);

console.log(f);

console.log(newarr);


let d=newarr.filter(item=> item.salary>30000);

console.log(d);



newarr.forEach(element => {
    console.log(element);
});


let x=10;
function func7(){
    let y=20;
    function func8(){
        let z=30;
        console.log(x,y,z);
    }
    func8();
    console.log(z);
}
func7();


//CALCULATOR codes

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


