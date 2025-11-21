let test = "Hello World";
console.log(test);
console.log(test.slice(0,5)) //should log Hello -> note end index not included in output
console.log(test.includes("world")); //should return false because it is case Sensitive
console.log(test.includes("World")); //should return true