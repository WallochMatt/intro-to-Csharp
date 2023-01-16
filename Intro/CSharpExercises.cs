using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
For this next task, let's start by creating a new class called 'CSharpExercises'. We will use this class for the next couple tasks.
*/


namespace Intro
{
    internal class CSharpExercises
    {

        //methods
        public double RunPayCalculator(int hoursWorked, double payRate)
        {
            double totalPay;
            totalPay = hoursWorked * payRate;
            return totalPay;
        }


        /*
        Using a loop, display every number from 1 to 100 in the console. However...
        If the number is divisible by 3, display "fizz" instead of the number.
        If the number is divisible by 5, display "buzz" instead of the number.
        If the number is divisible by both 3 AND 5, display "fizzbuzz" instead of the number.
        If the number doesn't fit any of the above conditions, simply display the number itself!
        */
        public void DoFizzbuzz()
        {
            int current;
            current = 1;

            while(current < 101)
            {
                if (current % 5 == 0 && current % 3 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }

                else if(current % 3 == 0) 
                {
                    Console.WriteLine("fizz");
                }

                else if (current % 5 == 0) 
                {
                    Console.WriteLine("buzz");
                }

                else
                {
                    Console.WriteLine(current);
                }

                current++;
            }
        }


    }
}
