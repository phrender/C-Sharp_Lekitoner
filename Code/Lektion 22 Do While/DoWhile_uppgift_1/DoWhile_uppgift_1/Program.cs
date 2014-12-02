using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoWhile_uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bKeepRunning = true;
            char chMyInput = '\0';
            int[] arriMyIntegers = new int[5];

            do
            {

                for (int i = 0; i < arriMyIntegers.Length; i++)
                {
                    Console.Write("Enter a number: ");
                    arriMyIntegers[i] = int.Parse(Console.ReadLine());
                }

                foreach (int i in arriMyIntegers)
                {
                    Console.Write(i + ", ");
                };

                Console.WriteLine("\nContinue?: y/n");
                Console.Write("Answer: ");
                chMyInput = char.Parse(Console.ReadLine());

                if (chMyInput == 'n')
                {
                    bKeepRunning = false;
                }

                else if (chMyInput == 'y')
                {
                    Console.Clear();
                    Console.WriteLine("Starting new round!");
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Starting new round, because you can't read.");
                }

            } while(bKeepRunning == true);

            Console.WriteLine("Goodbye");
        }
    }
}
