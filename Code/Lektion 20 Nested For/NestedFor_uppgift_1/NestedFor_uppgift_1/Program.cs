using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NestedFor_uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create local variables
            int i, j;
            
            // 
            for (i = 2; i < 100; i++)
            {
                for (j = 2; j <= (i / j); j++)
                {
                    if ((i % j) == 0)
                    {
                        break; // If we have anything over after we use modulus it's not a prime number
                    }
                }
                
                // Write the primenumber
                if (j > (i / j))
                {
                    Console.WriteLine("{0} is prime", i);
                }
            }
            
            Console.ReadLine();
        }
    }
}
