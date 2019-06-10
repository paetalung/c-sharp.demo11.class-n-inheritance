using System;
using System.Collections.Generic;
using System.Text;

namespace demo11.class_n_inheritance
{
    public class Student
    {
        public int Score;
        public string Name;

        public Student(int score, string name) // Constructors
        {
            // use constructor to initial value
            Score = score;
            Name = name;
        }
        public Student() // Constructors(overloading)
        {

        }

        public void Say() // Method
        {
            Console.WriteLine("Hello");
        }
    }
}
