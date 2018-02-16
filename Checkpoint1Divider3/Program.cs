using System;
using System.Linq;

namespace Checkpoint1Divider3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                {
                    int a, b, i, sum = 0;
                    for (i = 1; i < 100; i++)
                    {
                        a = i % 3;
                        if (a == 0)
                        {
                            
                            sum ++;
                        }
                    }
                    Console.WriteLine("\nThe Sum of How Many Multiples of 3 Below 100 : {0}", sum);
                    Console.Read();
                }
            }
        }
        

      
    }
}
