//1.
let num = Math.floor(Math.random() * 10); 

console.log("Number:", num);

if (num === 0) console.log("Zero");
else if (num === 1) console.log("One");
else if (num === 2) console.log("Two");
else if (num === 3) console.log("Three");
else if (num === 4) console.log("Four");
else if (num === 5) console.log("Five");
else if (num === 6) console.log("Six");
else if (num === 7) console.log("Seven");
else if (num === 8) console.log("Eight");
else console.log("Nine");



//2.
let dayNumber = Math.floor(Math.random() * 7) + 1;

console.log("Day Number:", dayNumber);

if (dayNumber === 1) console.log("Sunday");
else if (dayNumber === 2) console.log("Monday");
else if (dayNumber === 3) console.log("Tuesday");
else if (dayNumber === 4) console.log("Wednesday");
else if (dayNumber === 5) console.log("Thursday");
else if (dayNumber === 6) console.log("Friday");
else console.log("Saturday");



//3.
let number = Math.pow(10, Math.floor(Math.random() * 4)); 

console.log("Number:", number);

if (number === 1) console.log("Unit");
else if (number === 10) console.log("Ten");
else if (number === 100) console.log("Hundred");
else if (number === 1000) console.log("Thousand");
else console.log("Invalid Number");


