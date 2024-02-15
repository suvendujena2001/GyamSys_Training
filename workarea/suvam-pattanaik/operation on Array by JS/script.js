var listofitemb = [1,2,3,4,5,6,7,8,9];
console.log(listofitemb);

//push operation
listofitemb.push(10);
console.log(listofitemb);
//pop operation
listofitemb.pop();

//shift operation
listofitemb.shift();
console.log(listofitemb);

//unshift operation
listofitemb.unshift(10);
console.log(listofitemb);

//.at operation
console.log(listofitemb.at(5));

// concatination operation
var fte =[100,200,300];

var listofallemp = listofitemb.concat(fte);
console.log(listofallemp);

//slice operation
let a = listofallemp.slice(2);
console.log(a);

//find operation
function test(value,i,listofallemp){return value >= 6;};
var b = listofallemp.findIndex(test);
console.log(b);

function test1(value,i,listofallemp){
    return value ==300;
};
var c = listofallemp.findLastIndex(test1);
console.log(c);






