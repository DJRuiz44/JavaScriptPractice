function isLeapYear(date){
  if(date % 4 == 0 && (date % 100 != 0 || (date % 100 ==0 && date % 400 == 0))){
    return date + " is a leap year.";
  } else {
    return date + " is not a leap year.";
  }
}
let year = 2024;
let result = isLeapYear(year);
console.log(result);