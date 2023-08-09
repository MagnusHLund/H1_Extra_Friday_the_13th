# Friday the 13th

This code uses DateTime to calculate all the dates which are friday the 13th, within 10 years.
Run the code and it will output "it is friday the 13th, the 13:xx:20xx".

It works using 2 methods, which are both static.
The Main method assigns the date plus 10 years to the variable called "tenYears".
Then it runs a while loop, which keeps running until "tenYears" is no longer the future, from the point of view on the "day" datetime variable.
Inside the while loop, the 2nd method gets called. This method is a boolean and it is called "IsFridayThe13th".

In the method "IsFridayThe13th", it checks if the day of the week is friday and day of the month is 13.
If those 2 requirements are true, then it returns true to the while loop if statement.
However if it does not meet the requirements of the if statement inside "IsFridayThe13th", then it returns false.

Once the if statement inside the while loop has gotten a true, then it creates a string which converts the "day" datetime variable into a string with only day, month and year.
An example of the output would be "13:10:2023".
Then to output the date to the user, there is a Console.WriteLine.
The output is then for example "it is friday the 13th, the 13:10:2023".

Once it has done that or if the while loop if statement gets a false response, then it just adds 1 day to the "day" datetime variable.
It then gets looped over and over, until the while loop is false.
