function avg(x,y){
    return 1+(x+y)/2
}
const sum=(p,q)=>{
    return p+q
}
console.log(sum(5,6))
console.log(avg(4,5));
console.log("Welcome to Javascript");
//print the marks of students
let marks={
    kalpana:90,
    archana:99,
    papa:89,
    monika:70
}
for (let i=0;i<Object.keys(marks).length;i++){
    console.log("the mark is  "+marks[Object.keys(marks)[i]])
}
for(let key in marks){
    console.log("The marks of "+key + marks[key])
}
//Enter a correct number
let nm=6
let i
/*while(i!=nm){
    console.log("Try again")
    i = prompt("Enter a number")
}*/
console.log("You have entered the correct number")
//mean of 5 numbers
const mean=(a,b,c,d)=>{
    return (a+b+c+d)/4
}
console.log(mean(5,6,7,8))

// String
let name="kalpana";
console.log(name.length)

let k=8;
let m=7;
console.log(`${k} and ${m}`)
//Escape character is use to special character
let fruit="kal \"pana"
console.log(fruit)

//string methods
let name1="kalpana";
console.log(name1.toUpperCase())
console.log(name1.toLowerCase())
console.log(name1.slice(2,4))
console.log(name1.replace("kalp","arch"))
let firstname="kalpana"
let lastname="  panigrahi"
console.log(firstname.concat(lastname))
console.log(lastname.trim())//it remove space from last and first of the string
//strings are immutable
console.log("kp\"*na")
// use of include function
const sentence="my name is kalpana panigrahi";
const word ="kalpana";
console.log(`the word " ${word} " ${sentence.includes(word) ? 'is': 'is not'}`);
