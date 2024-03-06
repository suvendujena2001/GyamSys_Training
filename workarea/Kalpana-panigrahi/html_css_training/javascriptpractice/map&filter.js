let arr=[45,32,79]
arr.map((value)=>{
    console.log(value+1)
    return value+1
  
})
//it return anew array for each is used to perform aoperation
console.log(arr)
//filter
let ab=[30,45,38,67,10,20,3]
let bn = ab.filter((a)=>{
    return a>30
})
console.log(bn)
// reduce methode
let arr3=[1,2,3,4,5,1,2,3]
let newarr=arr3.reduce((h1,h2)=>{
    return h1+h2
})
console.log(newarr)

let arr4=[1,2,3,4]
const reduce_fun=(h1,h2)=>{
    return h1+h2
}
let newarr3=arr4.reduce(reduce_fun)
console.log(newarr3)

//array of user input
let arr5=[1,2,3,4,5,6]
let abc=prompt("Enter a number")
abc = Number.parseInt(abc)
arr.push(abc)
console.log(arr)

//
let arr6=[1,2,3,4,5,6]
while(abcd!=0){
    let abcd=prompt("Enter a number")
abcd = Number.parseInt(abcd)
arr.push(abcd)
console.log(arr)
}
// do while loop
let arr7=[1,2,3,4,5,6]
do{
    let abcd=prompt("Enter a number")
abcd = Number.parseInt(abcd)
arr.push(abcd)
console.log(arr)
}while(abcd!=0)

//filter the elements of array which is divisible by 10

let kp=[10,20,30,33,44,55]
let n= kp.filter((x)=>{
    return x%10==0
})
console.log(n)

//create a array of square of given numbers
let givenarr=[2,4,6,8]
let sqarr=givenarr.map((x)=>{
    return x*x
})
console.log(sqarr)

//using reduce function calculate factorial
let number=[1,2,3,4,5]
let fact=number.reduce((h1,h2)=>{
    return h1*h2
})
console.log(fact)