
// // call by value 
// let a=1;
// let b=a;
// b=2;
// console.log("a="+a);
// console.log("b="+b);


// //call by reference
// let arr=["x","y","z"];
// let arr1=arr;
// arr1.push("x");
// console.log(arr);
// console.log(arr1)
 
// //map and filter
// let arr2=[1,2,3,4,5];
// let arr3=arr2.filter(x=>x>2);
// console.log(arr3);
// let arr4=arr2.map(x=>x-1);
// console.log(arr4);

// //object creation
// let obj={
//     name:'adi',
//     degree:'btech',
//     course:'cse'};
// console.log(obj);


// // // ---------------------------------------------------------------------------------------------------------------

// /// 14-02-2024 --->

// let empNames=['adi','abhi','avi','prince','oggy','abhi'];
// console.log(empNames.pop());//pop
// console.log(empNames);
// console.log(empNames.push('oggy'));//push
// console.log(empNames);
// console.log(empNames.unshift('sahu'));//unshift
// console.log(empNames);
// console.log(empNames.shift('sahu'));//shift
// console.log(empNames);
// console.log(empNames.slice(2,4));//slice
// console.log(empNames);//does not change the original array
// console.log(empNames.at(2));//particular index
// console.log(empNames.indexOf('oggy'));//indexOf
// console.log(empNames.lastIndexOf('abhi'));//lastIndexOf
// let con=['kumar','thakur','roy'];
// let add=empNames.concat(con);//concatenation
// console.log(add);
// function test(value,i,final){ return value=='abhi';}
//     console.log( empNames.find(test));//find
//     console.log(empNames.findIndex(test));//findIndex
//     console.log(empNames.findLastIndex(test));//findLastIndex

//---------------------------------------------------------------------------------

//16-02-2024--> AJAX

function load(){
var xhttp= new XMLHttpRequest();
xhttp.onreadystatechange=function(){
    if (this.readyState == 4 && this.status == 200) {
        document.getElementById("container").innerHTML =this.responseText;
      }
    };
    xhttp.open("GET", "ajax.txt", true);
  xhttp.send();
}
//----------------------------------------------------------------------------------



