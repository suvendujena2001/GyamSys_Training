function Today_date() {
  document.getElementById("demo").innerHTML = Date();
}
const btn = document.getElementById("backgroundchange");

function random(number) {
  return Math.floor(Math.random() * (number + 1));
}

btn.addEventListener("mouseover", () => {
  const rndCol = `rgb(${random(255)}, ${random(255)}, ${random(255)})`;
  document.body.style.backgroundColor = rndCol;
});
console.log("hello JavaScript");
const fruits = ["Banana", "Orange", "Apple", "Mango"];
console.log(fruits);
console.log(
  "Does fruits array contains Mango? " + "\n" + fruits.includes("Mango")
);

let position = fruits.lastIndexOf("Apple") + 1;
console.log("position of Apple in the fruits array is " + position);
