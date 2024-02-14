
/// 14-02-2024 --->

let empNames=['adi','abhi','avi','prince','oggy','abhi'];
console.log(empNames.pop());//pop
console.log(empNames);
console.log(empNames.push('oggy'));//push
console.log(empNames);
console.log(empNames.unshift('sahu'));//unshift
console.log(empNames);
console.log(empNames.shift('sahu'));//shift
console.log(empNames);
console.log(empNames.slice(2,4));//slice
console.log(empNames);//does not change the original array
console.log(empNames.at(2));//particular index
console.log(empNames.indexOf('oggy'));//indexOf
console.log(empNames.lastIndexOf('abhi'));//lastIndexOf
let con=['kumar','thakur','roy'];
let add=empNames.concat(con);//concatenation
console.log(add);
function test(value,i,final){ return value=='abhi';}
    console.log( empNames.find(test));//find
    console.log(empNames.findIndex(test));//findIndex
    console.log(empNames.findLastIndex(test));//findLastIndex


 