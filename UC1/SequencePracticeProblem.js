//1.
let digit = Math.floor(Math.random() * 10);

console.log(digit);


//2. Get random dice no.

let number = Math.floor(Math.random() * 6) + 1;
Console.log("D-no: " + number);


//3. Add two dice no
let n1 = Math.floor(Math.random() * 6) + 1;
let n2 = Math.floor(Math.random() * 6) + 1;

console.log(n1 + n2);

//4.find 5 2 digit random no. sum and avg.
let sum = 0;
for (let i = 0; i < 5; i++){
    let number = Math.floor(Math.random * 90)+10;
    sum += number;
}

console.log("Sum: " + sum + " Avg: " + sum / 5);


//5.
let inches = 42;
let feet = inches / 12;
console.log("42 inches in feet:", feet);

// 5b. Convert Rectangular Plot of 60 feet x 40 feet into meters
let lengthFeet = 60;
let widthFeet = 40;
let lengthMeters = lengthFeet * 0.3048;
let widthMeters = widthFeet * 0.3048;
console.log("Rectangular Plot in meters:", lengthMeters, "x", widthMeters);

// 5c. Calculate Area of 25 Such Plots in Acres
let areaInMeters = lengthMeters * widthMeters;
let totalAreaMeters = areaInMeters * 25;
let areaInAcres = totalAreaMeters / 4046.86;
console.log("Total Area of 25 plots in acres:", areaInAcres);