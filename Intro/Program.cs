/*Your first C# task is to write some code using variables, data types, and operators to create a "pay calculator" 
to determine how much money someone has made. Overtime is NOT taken into account.
*/

using Intro;

int hoursWorked;
hoursWorked= 35;

double payRate;
payRate = 7.25D;

double totalPay;
totalPay=hoursWorked*payRate;

Console.WriteLine(totalPay);
Console.ReadLine();

/*
Your next C# task will be to create a class with a couple member variables.
Go ahead and create a class called 'Student'. 
This can be done in the project that you used for the previous task, or a brand new project if you want.
*/

Student mySelf = new Student();
mySelf.name = "Matthew Walloch";
mySelf.overallGradePercentage= 108.36;

//Console.WriteLine("Name: " + mySelf.name + "\n" + "Overall Grade: " + mySelf.overallGradePercentage + "%");
//Console.ReadLine();