let balance= 30;

const deposit = Number(prompt("Please write amount"));
const withdraw = Number(prompt("Please write amount"));



if (withdraw>balance)
console.log("In your balance you dont have that much money");
if (withdraw<balance)
console.log("Your operation is successful");
if(deposit>1)
console.log("Your operation is successful");
if(deposit<=0)
console.log("Please write more than 1$ amount");
