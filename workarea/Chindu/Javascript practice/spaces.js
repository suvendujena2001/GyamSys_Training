//global spaces
let globalVariable = 10;

function someFunction() {
    console.log(globalVariable); // Output: 10
}

console.log(globalVariable); // Output: 10
//function scope
function someFunction() {
    let functionScopedVariable = 20;
    console.log(functionScopedVariable); // Output: 20
}

someFunction();
console.log(functionScopedVariable); // ReferenceError: functionScopedVariable is not defined

//Block scope
if (true) {
    let blockScopedVariable = 30;
    console.log(blockScopedVariable); // Output: 30
}

console.log(blockScopedVariable); // ReferenceError: blockScopedVariable is not defined

