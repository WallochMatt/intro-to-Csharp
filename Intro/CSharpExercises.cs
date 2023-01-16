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
    }
}
