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




