function fearNotLetter(oneLetter){
  let counter = oneLetter[0].charCodeAt();
  for(const letter of oneLetter){
    console.log(letter.charCodeAt());
    if(letter.charCodeAt() != counter){
      return String.fromCharCode(letter.charCodeAt() - 1);
    } else {
      counter++;
    }
  }
  return undefined;
}

let result = fearNotLetter("abce");
console.log(result);