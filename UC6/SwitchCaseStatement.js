//1.
let num = Math.floor(Math.random() * 10);
console.log("Number:", num);

switch (num) {
  case 0:
    console.log("Zero");
    break;
  case 1:
    console.log("One");
    break;
  case 2:
    console.log("Two");
    break;
  case 3:
    console.log("Three");
    break;
  case 4:
    console.log("Four");
    break;
  case 5:
    console.log("Five");
    break;
  case 6:
    console.log("Six");
    break;
  case 7:
    console.log("Seven");
    break;
  case 8:
    console.log("Eight");
    break;
  case 9:
    console.log("Nine");
    break;
  default:
    console.log("Invalid Number");
}

//2.
let dayNumber = Math.floor(Math.random() * 7) + 1;
console.log("Day Number:", dayNumber);

switch (dayNumber) {
  case 1:
    console.log("Sunday");
    break;
  case 2:
    console.log("Monday");
    break;
  case 3:
    console.log("Tuesday");
    break;
  case 4:
    console.log("Wednesday");
    break;
  case 5:
    console.log("Thursday");
    break;
  case 6:
    console.log("Friday");
    break;
  case 7:
    console.log("Saturday");
    break;
  default:
    console.log("Invalid Day");
}

//3.
let number = Math.pow(10, Math.floor(Math.random() * 4));
console.log("Number:", number);

switch (number) {
  case 1:
    console.log("Unit");
    break;
  case 10:
    console.log("Ten");
    break;
  case 100:
    console.log("Hundred");
    break;
  case 1000:
    console.log("Thousand");
    break;
  default:
    console.log("Invalid Number");
}

//4.

const prompt = require("prompt-sync")();

console.log("Choose conversion: ");
console.log("1. Feet to Inch");
console.log("2. Feet to Meter");
console.log("3. Inch to Feet");
console.log("4. Meter to Feet");

let choice = parseInt(prompt("Enter your choice (1-4): "));
let value = parseFloat(prompt("Enter value to convert: "));

switch (choice) {
  case 1:
    console.log(value + " Feet =", value * 12, "Inches");
    break;
  case 2:
    console.log(value + " Feet =", value * 0.3048, "Meters");
    break;
  case 3:
    console.log(value + " Inches =", value / 12, "Feet");
    break;
  case 4:
    console.log(value + " Meters =", value * 3.28084, "Feet");
    break;
  default:
    console.log("Invalid Choice");
}