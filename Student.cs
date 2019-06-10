using System;
using System.Collections.Generic;
using System.Text;

namespace demo11.class_n_inheritance
{
    public class Student
    {
        public int Score;
        public string Name;
    }

    public class GradeCal
    {
        public string CalGrade(Student s)
        {
            if (s.Score > 90) return "A";
            else if(s.Score > 80) return "B";
            else if (s.Score > 70) return "C";
            else if (s.Score > 60) return "D";
            else return "F";
        }
    }
}
