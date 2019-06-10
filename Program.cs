using System;

namespace demo11.class_n_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // [class]
            // Field & Access modifier (public/private)
            // Constructors(overloading) (private constructor)
            // Method(overloading)
            // Properties

            Student s1 = new Student();
            s1.Name = "Pae";
            s1.Score = 95;

            GradeCal cal = new GradeCal();
            string grade = cal.CalGrade(s1);
            Console.WriteLine(s1.Name + " got " + grade);

            var s2 = new Student() // another way to set value
            {
                Name = "Dan",
                Score = 95
            };
            var grade2 = cal.CalGrade(s2);
            Console.WriteLine(s2.Name + " got " + grade2);
        }
    }
}
