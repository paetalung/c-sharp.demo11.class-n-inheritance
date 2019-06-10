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

            Student s1 = new Student()
            {
                Name = "Pae",
                Score = 95
            };
            
            var s2 = new Student() // Var is another way
            {
                Name = "Dan",
                Score = 65
            };

            var stu = new Student[2]; // array of method
            stu[0] = s1;
            stu[1] = s2;

            GradeCal cal = new GradeCal();
            for (int j = 0; j < stu.Length; j++)
            {
                var grade = cal.CalGrade(stu[j]);
                Console.WriteLine(grade);
            }

            
           
        }
    }
}
