using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Size of different data types: ");
            Console.WriteLine("Size of an Integer: {0} byte(s)", sizeof(int));
            Console.WriteLine("Size of an Float: {0} byte(s)", sizeof(float));
            Console.WriteLine("Size of a Char: {0} byte(s)", sizeof(char));
            Console.WriteLine("Size of an Double: {0} byte(s)", sizeof(double));
            Console.WriteLine("Size of a Decimal: {0} byte(s)", sizeof(decimal));
            Console.WriteLine("Size of a Boolean: {0} byte(s)", sizeof(bool));

            string strName = "Kevin";
            Console.WriteLine("Size of an 5 Character String: {0} byte(s)", strName.Length * 2); // Each character in a string costs 2 bytes
        }
    }
}
