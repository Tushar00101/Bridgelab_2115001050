//1.
let n = 5; 
console.log("Powers of 2 up to 2^" + n + ":");

for (let i = 0; i <= n; i++) {
  console.log("2^" + i + " =", Math.pow(2, i));
}


//2.


let number = 5;
let harmonic = 0;

console.log("Harmonic Series:");
for (let i = 1; i <= number; i++) {
  harmonic += 1 / i;
  console.log("H" + i + " =", harmonic);
}
console.log("Nth Harmonic Number:", harmonic);

//3.

let num = 29; 
let isPrime = true;

if (num < 2) {
  isPrime = false;
} else {
  for (let i = 2; i * i <= num; i++) {
    if (num % i === 0) {
      isPrime = false;
      break;
    }
  }
}

console.log(num, "is", isPrime ? "a Prime Number" : "NOT a Prime Number");



//4.
let start = 10,
  end = 50; 

console.log("Prime numbers between", start, "and", end, ":");

for (let num = start; num <= end; num++) {
  let isPrime = true;
  if (num < 2) isPrime = false;

  for (let i = 2; i * i <= num; i++) {
    if (num % i === 0) {
      isPrime = false;
      break;
    }
  }

  if (isPrime) console.log(num);
}


//5.


let numb = 5; 
let factorial = 1;

for (let i = 1; i <= numb; i++) {
  factorial *= i;
}

console.log(num + "! =", factorial);


//6.

let digit = 84; 
console.log("Prime factors of", digit, ":");

for (let i = 2; i * i <= digit; i++) {
    while (digit % i === 0) {
        console.log(i);
        digit /= i;
    }
}

if (digit > 1) console.log(digit); 
