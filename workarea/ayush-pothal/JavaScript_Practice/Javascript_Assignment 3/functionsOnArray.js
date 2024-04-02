var arr=[1,2,3,4,5,6,7,8,9,0];
arr.push(10);
console.log(arr);
arr.pop();
console.log(arr);
arr.shift();
console.log(arr);
arr.unshift(11);
console.log(arr);

console.log(arr.at(4));

console.log(arr.slice(2,3));

var arr1=[12,13,14,15];
var arr2=arr1.concat(arr);
console.log(arr2);

console.log(arr.indexOf(3));

console.log(arr.lastIndexOf(4));

function testing(value,i,arr)
{
    return value>=5;
}
console.log(arr.find(testing));
console.log(arr.findIndex(testing));
console.log(arr.findLastIndex(testing));
