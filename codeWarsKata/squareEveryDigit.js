function squareDigits(num) {
    // may the code be with you
    var returnStr = "";
    var numString = num.toString();
    for (var _i = 0, numString_1 = numString; _i < numString_1.length; _i++) {
        var digit = numString_1[_i];
        //console.log(digit);
        var squared = Number(digit) * Number(digit);
        returnStr += squared;
    }
    return Number(returnStr);
}
console.log(squareDigits(1234));
