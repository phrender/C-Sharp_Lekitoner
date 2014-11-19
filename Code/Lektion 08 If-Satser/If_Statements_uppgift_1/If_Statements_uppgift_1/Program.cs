using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace If_Statements_uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a choise variable and another answer
            int iChoise = 0;
            int iAnswer = 4;

            // Depending on what we choose different things happen
            Console.Write("Enter a choise between 1 and 3");
            iChoise = int.Parse(Console.ReadLine());

            Console.Write("What is 2 + 2? Answer: ");
            iAnswer = int.Parse(Console.ReadLine());

            if (iChoise == 1 && iAnswer == 4)
            {
                Console.WriteLine("You entered one.");
            }

            else if (iChoise == 2 && iAnswer == 4)
            {
                Console.WriteLine("You entered two.");
            }

            else if (iChoise == 3 && iAnswer == 4)
            {
                Console.WriteLine("You entered three.");
            }

            else
            {
                Console.WriteLine("You entered something else.");

                if (iAnswer == 4)
                {
                    Console.WriteLine("Math answer right.");
                }
            }

        }
    }
}
