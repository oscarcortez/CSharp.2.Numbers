using System;

namespace ConsoleApp4Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            // int
            int a = 5;
            int b = 4;
            int c = 2;
            int d = (a + b) * c; // 18
            int d1 = a + b * c; // 5+4*2 = 13
            Console.WriteLine(d);
            Console.WriteLine(d1);
            Console.WriteLine(Math.Pow(d,2));

            int max = int.MaxValue;
            int min = int.MinValue;

            Console.WriteLine($"integers: {max} and {min}");

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");

            int what2 = min - 3;
            Console.WriteLine($"An example of underflow: {what2}");

            // double
            double third = 1.0 / 3.0;
            Console.WriteLine(third);

            // declare a decimal
            decimal numDecimal = 12.12m;

            // declare a float
            float numFloat = 12.12f;

            // declare a double 
            double numDouble = 12.12d;

            //

            Double x = .1f;
            Double result = 10f * x;
            Double result2 = x + x + x + x + x + x + x + x + x + x;
            Console.WriteLine("{0} - {1}", result, result2);

            Math.Pow(2, 2);
            Math.Sqrt(9);

            Math.Pow(2, 2);

            var xxx = Math.PI;

            Console.WriteLine(xxx);

            // int a1; // must have a value
            // Console.WriteLine(a1);
        }
    }
}
