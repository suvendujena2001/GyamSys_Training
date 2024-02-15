const students=['Divya','Akshay','Priya','Nithin','likith','Manish'];
let size=students.length;
console.log(size);

console.log(students.toString());

let cr=students.at(2);
console.log(cr);

let joinstar=students.join('*');
console.log(joinstar);

students.pop();
console.log(students);
students.push('Jhanavi');
console.log(students);

let shift=students.shift();
console.log(shift);                    //removes first array element

let unshift=students.unshift("preethi");
console.log(students);                 //adds new element at 0th index

const merger=['Avi','Keerthi'];
let student=students.concat(merger);
console.log(student);

let add=student.splice(2,0,"Deepa","Aditya");
console.log(add);                      //Adds new elements at specified positions

let sub=student.slice(2,3);
console.log(sub);                      //Remove elements at specified positions



