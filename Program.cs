using System;

namespace pj1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(multiply(3, 4));
            Class1 var1 = new Class1();
            var1.greeting();
            
        }

        static int multiply (int a, int b)
        {
            return a * b;
        }
    }
}
