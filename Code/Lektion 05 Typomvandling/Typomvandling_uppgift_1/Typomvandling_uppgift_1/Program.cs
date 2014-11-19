using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Typomvandling_uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare three string variables
            string strVariable01 = "15";
            string strVariable02 = "3,1415";
            string strVariable03 = "6,282";

            Console.WriteLine("String values:\n---------------");
            // Show the user the value of strVariable01
            Console.WriteLine("Value of strVariable01: {0}", strVariable01);
            Console.WriteLine("Value of strVariable02: {0}", strVariable02);
            Console.WriteLine("Value of strVariable03: {0}", strVariable03);

            // Declare a int, float, and a double and initialize them.
            int iMyInt = 0;
            double dMyDouble = 0.0d;
            float fMyFloat = 0.0f;

            Console.WriteLine("Converted values:\n---------------");
            // Convert the string value to a int, double or float
            iMyInt = int.Parse(strVariable01);
            dMyDouble = double.Parse(strVariable02);
            fMyFloat = float.Parse(strVariable03);

            // Show the user the converted values
            Console.WriteLine("Value of iMyInt: {0}", iMyInt);
            Console.WriteLine("Value of dMyDouble: {0}", dMyDouble);
            Console.WriteLine("Value of fMyFloat: {0}", fMyFloat);
        }
    }
}
     