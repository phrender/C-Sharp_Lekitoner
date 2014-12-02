using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Foreach_uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // We create a  dictionary to hold a key and a value
            Dictionary<int, string> myDictionaty = new Dictionary<int, string>();
            
            // We insert a key collected from the for loop
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter name to spot[{0}] in the dictionary: ", i + 1);
                myDictionaty.Add(i, Console.ReadLine());
            }

            // We loop through all th string values inserted in the dictionary
            foreach (string strDicName in myDictionaty.Values)
            {
                Console.WriteLine("Name: {0}", strDicName);
            }

        }
    }
}
