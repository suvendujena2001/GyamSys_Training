// implementation of callback stack call back queue, call by value, call by stack

//call by value in variable
var a=5;
var b=a;
console.log('before changing the value of b, a='+a);
console.log('before changing the value of b, b='+b);
b=4;
console.log('after changing the value of b, a='+a);
console.log('after changing the value of b, b='+b);

//call by value in array
var arr=[1,4,6,2,1];
var copyarr=arr;

console.log('original array before adding 50:'+arr);
console.log('copy array before adding 50:'+copyarr)
copyarr.push(50);
console.log('copy array after adding 50:'+copyarr);
console.log('Original array after adding 50:'+arr);


//call stack

function first_f() {
    second_f();
    console.log('first function');
}

function second_f(){
    third_f();
    console.log('second function');
}

function third_f(){
    var x=9;
    console.log('x='+x);
    console.log("third function");
}

first_f();


//using setTimeout and Callback Queues

// console.log('message will be displayed after some time (first message):');
function displayMessage1() {
    console.log("First message--wait time 2000ms--Hello, world!");
}
setTimeout(displayMessage1, 2000);


function displayMessage2() {
    console.log("Second message--wait time 3000ms--Hello, Soumyadip");
}
setTimeout(displayMessage2, 3000);


function displayMessage3() {
    console.log("Third message--wait time 1000ms--Welcome to js!");
}
setTimeout(displayMessage3, 1000);


//array, map, filter

var arr2=[1,4,2,5,6];
console.log('array 2 before filtering: '+ arr2);
var filt=arr2.filter(i=>i>=3);
console.log('filterded values: '+ filt);
console.log('array 2 after filtering: '+ arr2);
// function great(item)
// {
//     return item>=2;
// }
console.log('array 2 before mapping: '+ arr2);
var mapp=arr2.map(i=>i*3);
console.log('mapped values: '+ filt);
console.log('array 2 after maping: '+ mapp);


//push,pop,shift, unshift, concat, slice 

var arr3=[3,2,6,4,3,9,8,6,4];
console.log(arr3);
arr3.push(40);
console.log(arr3);
arr3.shift();
console.log(arr3);
arr3.unshift(8);
console.log(arr3);
var arr4=[100,300,345,3746,8939];
var arr5=arr3.concat(arr4);
console.log(arr5);
console.log(arr5.slice(5));
console.log(arr5.slice(3,8));


//find,findIndex, findLastIndex

const  found = arr5.find((element) => element > 40);
console.log(found);

const  foundindex = arr5.findIndex((element) => element == 6);
console.log(foundindex);

const  foundlastindex = arr5.findLastIndex((element) => element == 6);
console.log(foundlastindex);
