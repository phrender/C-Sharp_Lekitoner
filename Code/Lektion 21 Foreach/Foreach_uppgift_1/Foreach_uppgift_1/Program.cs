using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Foreach_uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array we will retrive information from
            int[] arriMyIntegers = new int[] { 120, 31, 4565, -321, -75 };

            foreach (int i in arriMyIntegers)
            {
                Console.WriteLine("arriMyIntegers: {0}", i);
            }

        }
    }
}
