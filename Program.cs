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

            Student s1 = new Student(5,"Plypun");
            Console.WriteLine(s1.Score);
            Console.WriteLine(s1.Name);

            Student s2 = new Student(96,"Paetalung");
            Console.WriteLine(s2.Score);
            Console.WriteLine(s2.Name);

            // create obj by Constructors(overloading)
            Student s3 = new Student();
            s3.Score = 50;
            s3.Name = "oho";
            Console.WriteLine(s3.Score);
            Console.WriteLine(s3.Name);

            s1.Say();
        }
    }
}
