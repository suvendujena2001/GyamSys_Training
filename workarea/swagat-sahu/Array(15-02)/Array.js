var col = [1,2,3,4,5,6,7,8,9];
col.push(10);//Enters list of elements at the end of the list.
col.shift();//Removes the first element.
console.log(col);
console.log(col.unshift(9));//Adds element to the First index 
console.log(col.at(7));//Returns index of 7
var col2 = [11,22,33,44];
var apple = col.concat(col2);//Concats the 2 arrays.
console.log(apple);
console.log(col.slice(2,4));//Slices out the mentioned part. 
console.log(col.lastIndexOf(8));//returns last index of 8.
function test(val, i, col)
{
    return val>5;
}
console.log(col.find(test));//Returns value of first element >5
console.log(col.findIndex(test));//Returns index of first element >5
console.log(col.findLastIndex(test));//Last index of element greater than 5.

