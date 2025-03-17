//1.

let n = 10;
let power = 0;

console.log("Powers of 2 up to 2^" + n + " or 256:");

while (Math.pow(2, power) <= 256 && power <= n) {
  console.log("2^" + power + " =", Math.pow(2, power));
  power++;
}

//2.
let low = 1,
  high = 100;
let magicNumber = Math.floor(Math.random() * 100) + 1;
let guess = 0;

console.log("Think of a number between 1 and 100...");

while (low <= high) {
  let mid = Math.floor((low + high) / 2);
  console.log("Is it", mid, "?");

  if (mid === magicNumber) {
    console.log("Yay! The Magic Number is:", mid);
    break;
  } else if (mid > magicNumber) {
    console.log("No, it's smaller.");
    high = mid - 1;
  } else {
    console.log("No, it's larger.");
    low = mid + 1;
  }
}

//3.
let heads = 0,
  tails = 0;

while (heads < 11 && tails < 11) {
  let flip = Math.floor(Math.random() * 2);

  if (flip === 1) {
    heads++;
    console.log("Heads! Total:", heads);
  } else {
    tails++;
    console.log("Tails! Total:", tails);
  }
}

console.log((heads === 11 ? "Heads" : "Tails") + " won 11 times!");

//4.

let money = 100,
  wins = 0,
  bets = 0;

while (money > 0 && money < 200) {
  bets++;
  let betResult = Math.floor(Math.random() * 2);

  if (betResult === 1) {
    money++;
    wins++;
  } else {
    money--;
  }
}

console.log("Final Money:", money);
console.log("Total Bets Made:", bets);
console.log("Total Wins:", wins);
console.log(money >= 200 ? "Goal Reached!" : "Broke!");
