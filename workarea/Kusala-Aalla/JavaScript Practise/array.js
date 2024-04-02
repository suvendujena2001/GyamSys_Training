var contractors = [10,20,30,40,50];
console.log(contractors.pop()); //pop will remove the last element

var fte = [60,70,80,90,60];
var all = (contractors.concat(fte));
console.log(all);

contractors.shift();
console.log(shift()); //shift will remove the first element

fte.unshift(60);
console.log(unshift()); //unshift will add the elements in begining

var empname=['sneha','ramya','deepak','ravi','sneha','ramya'];
console.log(empname.slice(1,2)); //slice will remove begining of an array and it wont change the exist array

console.log(indexof('ravi')); //indexof is used to find the index of first occurance
console.log(lastindexof('ramya')); //lastindexof is used to find the index of last occurance

