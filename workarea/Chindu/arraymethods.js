let numbers = [1, 2, 3, 4, 5];

// 1. forEach method
console.log("forEach:");
numbers.forEach(function(number) {
  console.log(number);
});

// 2. map method
console.log("map:");
let doubledNumbers = numbers.map(function(number) {
  return number * 2;
});
console.log(doubledNumbers);

// 3. filter method
console.log("filter:");
let evenNumbers = numbers.filter(function(number) {
  return number % 2 === 0;
});
console.log(evenNumbers);

// 4. reduce method
console.log("reduce:");
let sum = numbers.reduce(function(acc, curr) {
  return acc + curr;
}, 0);
console.log(sum);

// 5. find method
console.log("find:");
let foundNumber = numbers.find(function(number) {
  return number > 3;
});
console.log(foundNumber);

// 6. indexOf method
console.log("indexOf:");
let index = numbers.indexOf(3);
console.log(index);

// 7. includes method
console.log("includes:");
let includesNumber = numbers.includes(6);
console.log(includesNumber);

// 8. slice method
console.log("slice:");
let slicedNumbers = numbers.slice(1, 3);
console.log(slicedNumbers);

// 9. splice method
console.log("splice:");
let removedNumbers = numbers.splice(1, 2);
console.log(removedNumbers);
console.log(numbers); // original array modified

// 10. push method
console.log("push:");
numbers.push(6);
console.log(numbers);

// 11. pop method
console.log("pop:");
let poppedNumber = numbers.pop();
console.log(poppedNumber);
console.log(numbers);

// 12. shift method
console.log("shift:");
let shiftedNumber = numbers.shift();
console.log(shiftedNumber);
console.log(numbers);

// 13. unshift method
console.log("unshift:");
numbers.unshift(0);
console.log(numbers);

// 14. concat method
console.log("concat:");
let newNumbers = numbers.concat([7, 8, 9]);
console.log(newNumbers);

// 15. join method
console.log("join:");
let joinedString = numbers.join("-");
console.log(joinedString);

// 16. reverse method
console.log("reverse:");
let reversedArray = numbers.reverse();
console.log(reversedArray);

// 17. sort method
console.log("sort:");
let sortedArray = numbers.sort(function(a, b) {
  return a - b;
});
console.log(sortedArray);
