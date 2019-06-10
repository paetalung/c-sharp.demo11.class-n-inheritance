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
            //s1.Score = 5;
            Console.WriteLine(s1.Score);
            Console.WriteLine(s1.Name);

            Student s2 = new Student();
            s2.Score = 99;
            s2.Name = "Paetalung";
            Console.WriteLine(s2.Score);
            Console.WriteLine(s2.Name);
        }
    }
}
