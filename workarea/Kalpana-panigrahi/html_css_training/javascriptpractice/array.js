let a=[1,2,3,4,5,"kalpana"]
console.log(a[0])
//adding to new value
a[7]=89;
//change in the of an array
a[0]=45;
console.log(a[0])
//arrays are mutable
//array methods
let num=[1,2,3,28,5]
let b= num.toString()//converting array to string
let c= num.join('-')// add - ono after one
console.log(c)
console.log(num.pop())//pop returned the poped element
let r= num.push(56)
console.log(num,r)
//shift remove the first element and print the shifted element
console.log(num.shift())
//unshift add new elements on the first
let k =num.unshift(78)
console.log(num,k)
let g = num.unshift(50)
delete num[0]
console.log(num)
//delet is a operator
delete num[0]

console.log(num)
//concate is used to add one or more array
//sort methode is used to sort the elements alphabetically
console.log(num.sort())//it modify the original array

let compare = (a,b)=>{
    return b-a
}
num.sort(compare)

console.log(num)
console.log(num.reverse())

// array with for loop
let num1=[3,54,1,2,8]
for(let i=0; i<num1.length;i++){
    console.log(num1[i])
}
num1.forEach((element)=>{
    console.log(element)
})
//when we have html collection we can not use foreach we use array form
let name2="kalpana"
let arr=Array.from(name2)
console.log(arr)

//for...of
for(let i of name2){
    console.log(i)
}
for(let i of num){
    console.log(i)
}


