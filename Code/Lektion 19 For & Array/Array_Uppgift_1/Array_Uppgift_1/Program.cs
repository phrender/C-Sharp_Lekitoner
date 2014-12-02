using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array_Uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array of integers and fill it with calues
            int[] arriMyIntegers = new int[] { 10, 20, 30, 40, 50 };

            Console.WriteLine("Get data from array:");

            // Extract the data
            for (int i = 0; i < 5; i++)
            { 
                // We use [i] to access the value of the specific element
                Console.WriteLine("Entry: {0}", arriMyIntegers[i]);
            }
        }
    }
}
