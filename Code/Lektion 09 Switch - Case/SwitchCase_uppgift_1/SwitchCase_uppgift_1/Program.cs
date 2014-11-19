using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwitchCase_uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {

            char chInput = '\n';

            Console.Write("Enter choise: ");
            chInput = Console.ReadKey().KeyChar;
            Console.WriteLine("\n");

            switch (chInput)
            {
                case 'a':
                    Console.WriteLine("You clicked {0}", chInput);
                    break;

                case 'b':
                    Console.WriteLine("You clicked {0}", chInput);
                    break;

                case 'z':
                    Console.WriteLine("You clicked {0}", chInput);
                    break;

                default:
                    Console.WriteLine("{0} is no a valid answer.", chInput);
                    break;
            };

        }
    }
}
