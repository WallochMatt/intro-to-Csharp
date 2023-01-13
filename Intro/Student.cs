using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    internal class Student
    {
        public string? name;

        public double overallGradePercentage;

        public bool isGraduate;



        public Student(string name, double overallGradePercentage)
        {
            this.name = name;
            this.overallGradePercentage= overallGradePercentage;
            this.isGraduate = false;
        }

        public void MakeStudentAGraduate()
        {
            isGraduate = true;
        }
    }
}
