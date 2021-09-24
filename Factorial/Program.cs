using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int factorial = 5;
            int product = 1;
            for (int i = 1; i <= 5; i++)
            {
                product *= i;
            }
            Console.WriteLine("$Factorial is  {0}",product);
            Console.WriteLine("Ran at " + DateTime.Now);
        }
    }
}
