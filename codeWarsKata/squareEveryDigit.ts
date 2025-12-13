function squareDigits(num: number): number {
  // may the code be with you
  let returnStr: string = "";
  const numString: string = num.toString();
  for (const digit of numString) {
    //console.log(digit);
    let squared: number = Number(digit) * Number(digit);
    returnStr += squared;
  }
  return Number(returnStr);
}

console.log(squareDigits(1234));
