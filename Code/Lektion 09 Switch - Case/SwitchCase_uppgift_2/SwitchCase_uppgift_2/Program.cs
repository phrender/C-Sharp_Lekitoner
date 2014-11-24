using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwitchCase_uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string strInput = string.Empty;

            Console.Write("Enter a data type: ");
            strInput = Console.ReadLine();

            switch (strInput)
            {
                case "string":
                    string strStringValue = strInput.ToString();
                    Console.WriteLine("Our string value contains: {0} and costs {1} bytes of memory", strStringValue, strStringValue.Length * 2);
                    break;

                case "int":
                    int iMyInt = strInput.Length;
                    Console.WriteLine("Our int has the value of: {0} and costs {1} bytes of memory", iMyInt, sizeof(int));
                    break;

                case "float":
                    float fMyFloat = strInput.Length;
                    Console.WriteLine("Our float has the value of: {0} and costs {1} bytes of memory", fMyFloat, sizeof(float));
                    break;

                case "double":
                    int dMydouble = strInput.Length;
                    Console.WriteLine("Our double has the value of: {0} and costs {1} bytes of memory", dMydouble, sizeof(double));
                    break;

                default:
                    Console.WriteLine("Either incorrect data type or this probram does not support the given data type.");
                    break;
            };
        }
    }
}
