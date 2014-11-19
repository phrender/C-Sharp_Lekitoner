using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Typomvandling_uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declerate three varaibles
            string strValue01 = "15";
            double dValue02 = 13.00d;
            float fValue03 = 14.50f;

            // Show the user our variables and thier values
            Console.WriteLine("strValue01 holds: {0} as value", strValue01);
            Console.WriteLine("dValue02 holds: {0} as value", dValue02);
            Console.WriteLine("fValue03 holds: {0} as value", fValue03);

            // Declarate three Integers and initialize them
            int iIntValue01 = 0;
            int iIntValue02 = 0;
            int iIntValue03 = 0;

            // Convert our first variables to Integers
            iIntValue01 = Convert.ToInt32(strValue01);
            iIntValue02 = Convert.ToInt32(dValue02);
            iIntValue03 = Convert.ToInt32(fValue03);

            // Show the user the converted values
            Console.WriteLine("iIntValue01: {0}", iIntValue01);
            Console.WriteLine("iIntValue02: {0}", iIntValue02);
            Console.WriteLine("iIntValue03: {0}", iIntValue03);
        }
    }
}
