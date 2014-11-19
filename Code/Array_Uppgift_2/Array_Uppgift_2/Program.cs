using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array_Uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array with five entries
            int[] arriMyIntegerArray = new int[5];

            Console.WriteLine("Enter numbers in to your array: ");
            // Create a for loop to push numbers in to the array
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Entry[{0}]: ", i + 1);
                // [i] is used to enter a specific element in the array
                arriMyIntegerArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n---------------\nRetrive data from the array:");

            for (int i = 0; i < 5; i++)
            {
                // Here we use i to enter the number of timers we've run
                // through the loop and arriMyIntegerArray[i] - here we use
                // i to access the value of the element in the array.
                Console.WriteLine("Entry[{0}]: {1}", i, arriMyIntegerArray[i]);
            }
        }
    }
}
