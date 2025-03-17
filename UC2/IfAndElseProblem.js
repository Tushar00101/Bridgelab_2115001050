//1. Generate 5 random 3-digit numbers
let num1 = Math.floor(Math.random() * 900) + 100;
let num2 = Math.floor(Math.random() * 900) + 100;
let num3 = Math.floor(Math.random() * 900) + 100;
let num4 = Math.floor(Math.random() * 900) + 100;
let num5 = Math.floor(Math.random() * 900) + 100;

console.log("Numbers:", num1, num2, num3, num4, num5);

// Find min and max
let min = Math.min(num1, num2, num3, num4, num5);
let max = Math.max(num1, num2, num3, num4, num5);

console.log("Min:", min);
console.log("Max:", max);



//2.
let day = parseInt(process.argv[2]); 
let month = parseInt(process.argv[3]); 

if (
  (month === 3 && day >= 20) ||
  (month > 3 && month < 6) ||
  (month === 6 && day <= 20)
) {
  console.log(true);
} else {
  console.log(false);
}



//3.
let year = parseInt(process.argv[2]); 
if (year >= 1000 && year <= 9999) {
  if ((year % 4 === 0 && year % 100 !== 0) || year % 400 === 0) {
    console.log(year, "Yes");
  } else {
    console.log(year, "No");
  }
} else {
  console.log("Please enter a 4-digit year");
}


//4.

let coinFlip = Math.floor(Math.random() * 2); 
if (coinFlip === 0) {
  console.log("Heads");
} else {
  console.log("Tails");
}
