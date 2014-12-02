using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoWhile_uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            bool bContinueInnerLoop = true;
            bool bContinueOuterLoop = true;

            do
            {
                for (i = 0; i < 10; i++)
                {
                    Console.WriteLine("Run: {0}", i);
                    if (i == 9)
                    {
                        bContinueOuterLoop = false;
                        break;
                    }
                }

                do
                {

                    for (j = i; j > 0; j--)
                    {
                        Console.WriteLine("Run: {0}", j);
                        if (j == 1)
                        {
                            bContinueInnerLoop = false;
                            break;
                        }
                    }

                } while (bContinueInnerLoop == true);

            } while (bContinueOuterLoop == true);

            Console.ReadLine();

        }
    }
}
