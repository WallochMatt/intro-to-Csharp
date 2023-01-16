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

        public List<int> studentProjectGradePercentages;



        public Student(string name)
        {
            this.name = name;
            this.isGraduate = false;
            this.studentProjectGradePercentages = new List<int>();
        }

        public void MakeStudentAGraduate()
        {
            isGraduate = true;
        }

        public void SetOverallGradePercentage()
        {
            int total;
            total = 0;
            foreach(int grade in studentProjectGradePercentages)
            {
                total += grade; 
            }

            overallGradePercentage = total / studentProjectGradePercentages.Count;
        }
    }
}
