////1.	We have an object storing salaries of our team

//let salaries = {
//    John: 100,
//    Ann: 160,
//    Pete: 130
//};
//Write the code to sum all salaries and store in the variable sum.
//Should be 390 in the example above.

//***********************************************Solution
//function sum(obj) {
//    var sum = 0
//    for (var num in obj) {
//        if (obj.hasOwnProperty(num)) {
//            sum += parseFloat(obj[num]);
//        }
//    }
//    return sum;
//}

//var summed = salaries[John] + salaries[Ann] + salaries[Pete];
//console.log("sum:" + summed);

// Test code:
var a = 10
console.log(a)





//2.	Create a function multiplyNumeric(obj) that multiplies all numeric properties of obj by 2
//// before the call
//let menu = {
//    width: 200,
//    height: 300,
//    title: "My menu"
//};

//multiplyNumeric(menu);

//// after the call
//menu = {
//    width: 400,
//    height: 600,
//    title: "My menu"
//};
//Please note that multiplyNumeric does not need to return anything.It should modify the object in -place

//***********************************************Solution
//let menu = {
//    width: 200,
//    height: 300,
//    title: "My menu"
//};

//menu[width] += 200
//menu[height] += 300

//console.log("menu:" + menu);




//3.	Write a function checkEmailId(str) that returns true if str contains '@' and ‘.’, 
//otherwise false.Make sure '@' must come before '.' and there must be some characters 
//between '@' and '.'
//The function must be case -insensitive:

//***********************************************Solution
//function checkEmailID(str) {
/*//    for (i = 0; i < str) {*/

//        if (str.includes('@') && str.includes('.')) {
//            if (str.indexOf(".") - str.indexOf("@") > 1) {
//                return true
//            } else {
//                return false
//            }
//        }
//    }

/*//}*/








//4.	Create a function truncate(str, maxlength) that checks the length of the str and, 
//if it exceeds maxlength – replaces the end of str with the ellipsis character "…", 
//to make its length equal to maxlength.
//The result of the function should be the truncated(if needed) string.
//    truncate("What I'd like to tell on this topic is:", 20) = "What I'd like to te…"

/*truncate("Hi everyone!", 20) = "Hi everyone!"*/


//***********************************************Solution
//function truncate(str, length) {
//    if (str.length <= length) {
//        return str
//    }

//    return str.slice(0, length) + "..."

//}




//5.	Let’s try 5 array operations.
//Create an array styles with items “James” and “Brennie”.
//var names = ["James", "Brennie"]; 

//Append “Robert” to the end.
//names.push("Robert")

//Replace the value in the middle by “Calvin”.Your code for finding the middle value should 
//work for any arrays with odd length.
//names[names.length / 2] = "Calvin"

//Remove the first value of the array and show it.
//first_value = names.shift();
//log.console(first_value);

//Prepend Rose and Regal to the array.
//names.unshift("Rose");
//names.unshift("Regal");
// Results:
//    James, Brennie
//James, Brennie, Robert
//James, Calvin, Robert
//Calvin, Robert
//Rose, Regal, Calvin, Robert


//***********************************************Solution

//var names = ["James", "Brennie"];
//names.push("Robert")

//names[names.length/2] = "Calvin"

//first_value = names.shift();
//log.console(first_value);

//names.unshift("Rose");
//names.unshift("Regal");



//6.	We are transitioning from people swiping their credit card to using a chip.
// As part of the transition, some credit card companies have moved all of their customers to 
// the new chip card, some are in the process, and some still have yet to comply.
// We need to implement a system that verifies the card swipe and determine if 
// we should authorize the transaction using a card swipe or if the customer needs to use 
// the chip feature of their card.

//We need you to implement the validateCards() function.
// We will pass in two lists of strings.
// We are doing batch authorization so the first parameter is a list of the swiped card number.
// The second is a list of card prefixes that cannot be processed if the card is swiped.

//The function should return a JSON array of credit card objects that contains: 
// Card(String): the card number isValid(boolean): 
// a modified Luhn check(described below) isAllowed(boolean): a check to verify that 
// the number doesn’t start with any of the card prefixes.

//The modified Luhn check verifies that the card was swiped correctly.
// We do his by calculating the check digit and comparing it to the last number on the card.
// We calculate the check digit by taking all but the last digit the card number, 
// take the int value of each individual character, double it, add them together, 
// then divide by 10 and take the reminder.That value is the calculated check digit.
// If this matches the check digit(last number in the string), then the card number is valid.

//Below is an example Let’s say we have a card number: 6724843711060148. The last number is 8. We then have the string 672484371106014. 
// We now take each character and convert it to a number: | 6 | 7 | 2 | 4 | 8 | 4 | 3 | 7 | 1 | 1 | 0 | 6 | 0 | 1 | 4 |

//    Then we double each number: | 12 | 14 | 4 | 8 | 16 | 8 | 6 | 14 | 2 | 2 | 0 | 12 | 0 | 2 | 8 |

//   Then we sum them up and get 108. 
// We divide by 100 and the remainder is 8. 
// The calculated check digit from our card matches the last number, 
// so we set isValid to true.If it were any other number, we would set it to false.

//For the full example, we would have the input parameter of: cardsToValidate(List of one credit card number): 6724843711060148 
// And bannedPrefixes(string): 11, 3434, 67453, 9 
// The result would be a JSON array with one credit card object{ [{ card: ”6724843711060148”, isValid: true, isAllowed: true}]

//function validateCards(str1, str2) {
//    var array = []

//    for (i = 0; i < str) {
//        array.push(i)
//    }

//    var double_array = []
//    for (i = 0; i < array) {
//        array.push(i*2)
//    }

//    var sum = 0

//    for (i = 0; i < double_array) {
//        sum += i
//    }

//    var str_sum = num.toString();
//    var lastDigit = str_sum.charAt(str.length - 1);
//    return lastDigit = str1.slice(-1)
//}








//7.	Validating Email Addresses with RegEx We consider an email address in the form user@domain.extension to be valid 
// if its domain and extension are hackerrank.com and the value of user satisfies the following constraints:
//a.It starts with between 1 and 6 lowercase English letters denoted by the character class [a - z].
//b.The lowercase letter(s) are followed by an optional underscore, i.e.zero or one occurrence of the character.
//c.The optional underscore is followed by 0 and 4 optional digits denoted by the character class[0 - 9].

//Complete the code in the editor below by replacing the bank(“_____”) with a regular expression that 
//matches valid email addresses according to the criteria above.Locked code in the editor prints True for each correct match and 
//False for each incorrect match.

//An example of a valid emails is abcdef_1234@hackerrank.com.It has as many of each class of character as possible.The address a1_1@baddomain.com fails for two reasons.First, digits cannot precede the underscore.Second, the domain fails because it is not hackerrank.

//    Constraints
//•	1 <= query <= 10 power of 3.
//•	1 <= string length <= 10 power of 3

//Input Format Locked stub code reads strings from stdin and processes them with your regex.

//The first line contains an integers, query, describing the total number of target strings to match against the regular expression.
//Each line i of the query subsequent lines contains a string describing the ith email address to validate.

//Sample Case 0
//Sample Input 0
//5
//julia@hackerrank.com
//julia_@hackerrank.com
//julia_0@hackerrank.com
//julia0_@hackerrank.com
//julia@gmail.com

//Sample Output 0
//True
//True
//True
//False
//False

//Explanation 0 We perform the following query = 5 validations:
//•	julia@hackerrank.com starts with between 1 and 6 lowercase letters and contains zero of the optional characters, so it’s valid.
//•	julia_@hackerrank.com starts with between 1 and 6 lowercase letters, is followed by a single underscore, and contains none of the optional digits, so it’s valid.
//•	julia_0@hackerrank.com starts with between 1 and 6 lowercase letters, is followed by a single underscore, and is followed by between 0 and 4 digits, so its valid.
//•	julia0_@hackerrank.com has valid lowercase letters followed by a valid digit, but the digit must not precede the underscore.
//•	julia@gmail.com has a valid username, but its domain and extension do not match hackerrank.com.

//***********************************************Solution

function validateEmail(email) {
    var re = /\S+@\S+\.\S+/;
    return re.test(email);
}

console.log(validateEmail('anystring@anystring.anystring'));
