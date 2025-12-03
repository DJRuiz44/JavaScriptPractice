function findOdd(A) {
  //happy coding!
  let frequency = {};
  for (let i = 0; i < A.length; i++) {
    if (A[i] in frequency) {
      frequency[A[i]] += 1;
    } else {
      frequency[A[i]] = 1;
    }
  }
  //console.log(frequency);
  for (let key in frequency) {
    if (frequency[key] % 2) {
      return parseInt(key);
    }
  }
}

console.log(findOdd([0, 1, 2, 3, 0, 1, 3]));
console.log(findOdd([1, 0, 0]));
