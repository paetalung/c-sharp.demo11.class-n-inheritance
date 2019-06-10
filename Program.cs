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
            s1.Score = 5;
            Console.WriteLine(s1.Score);
        }
    }
}
