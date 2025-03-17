//1.
function convertTemperature(choice, temp) {
  switch (choice) {
    case 1:
      if (temp < 0 || temp > 100) {
        console.log("Temperature out of range!");
        return;
      }
      console.log(temp + "°C =", (temp * 9) / 5 + 32 + "°F");
      break;

    case 2:
      if (temp < 32 || temp > 212) {
        console.log("Temperature out of range!");
        return;
      }
      console.log(temp + "°F =", (((temp - 32) * 5) / 9).toFixed(2) + "°C");
      break;

    default:
      console.log("Invalid Choice!");
  }
}

//convertTemperature(1, 25);
//convertTemperature(2, 98);

//2.

function isPalindrome(num) {
  let original = num.toString();
  let reversed = original.split("").reverse().join("");
  return original === reversed;
}

// Example Usage
let num1 = 121,
  num2 = 456;
console.log(
  num1,
  "is",
  isPalindrome(num1) ? "a Palindrome" : "NOT a Palindrome"
);
console.log(
  num2,
  "is",
  isPalindrome(num2) ? "a Palindrome" : "NOT a Palindrome"
);

//3.

function isPrime(num) {
  if (num < 2) return false;
  for (let i = 2; i * i <= num; i++) {
    if (num % i === 0) return false;
  }
  return true;
}

function getPalindrome(num) {
  return parseInt(num.toString().split("").reverse().join(""));
}

function checkPrimeAndPalindrome(num) {
  if (!isPrime(num)) {
    console.log(num, "is NOT a Prime Number");
    return;
  }

  console.log(num, "is a Prime Number");

  let palindrome = getPalindrome(num);
  console.log("Palindrome of", num, "is", palindrome);

  if (isPrime(palindrome)) {
    console.log(palindrome, "is also a Prime Number!");
  } else {
    console.log(palindrome, "is NOT a Prime Number");
  }
}

//checkPrimeAndPalindrome(31);
