using System;

namespace FactoralOfNumbers.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int factorial = 1;
            
            for (int i = number; i > 0; i--)
            {
                //5 x 4 x 3 x 2 x 1
                factorial = factorial * i;

            }
            
        }
    }
}
