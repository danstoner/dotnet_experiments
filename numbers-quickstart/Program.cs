using System;

namespace NumbersInCSharp
{
    class Program
    {
        static int AddTwo(int a, int b)
        {
            return a + b;
        }

        static int MultiplyTwo(int a, int b)
        {
            return a * b;
        }

        static void WorkingWithIntegers()
        {
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello Numbers");
            // WorkingWithIntegers();
            int a = 5;
            int b = 3;
            Console.WriteLine("AddTwo: " + AddTwo(a,b) );
            Console.WriteLine("MultiplyTwo: " + MultiplyTwo(a,b));
        }

    }
}
