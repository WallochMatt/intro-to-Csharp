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

//Console.WriteLine(totalPay);
//Console.ReadLine();

/*
Your next C# task will be to create a class with a couple member variables.
Go ahead and create a class called 'Student'. 
This can be done in the project that you used for the previous task, or a brand new project if you want.
*/



//Console.WriteLine("Name: " + mySelf.name + "\n" + "Overall Grade: " + mySelf.overallGradePercentage + "%");
//Console.ReadLine();

Student graduate = new Student("Gray Djuwit", 98);
graduate.MakeStudentAGraduate();

//Console.WriteLine("Name: " + graduate.name + "\n" + "Overall Grade: " + graduate.overallGradePercentage + "%" + "\n" + 
//    "Graduated?: " + graduate.isGraduate);
//Console.ReadLine();



/*In your new class, create a public member method called 'RunPayCalculator'. Give this method two parameters so that the
'hoursWorked' and 'payRate' can be passed into this method from the outside. This method is where you will write the logic
for your pay calculator! Your method should end by returning the calculated 'totalPay'.
*/
CSharpExercises calculator = new CSharpExercises();
//Console.WriteLine(calculator.RunPayCalculator(25, 10.50));
//Console.ReadLine();

calculator.DoFizzbuzz();