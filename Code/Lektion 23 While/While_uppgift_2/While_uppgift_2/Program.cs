using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace While_uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bContinue = true;
            string strPassword = string.Empty;
            int iNumberOfTries = 3;
            char chInput = '\n';

            while (bContinue)
            {
                Console.Write("Enter password: ");
                strPassword = Console.ReadLine();

                if (strPassword.Equals(""))
                {
                    Console.Clear();
                    Console.WriteLine("Welcome.");

                    while (bContinue)
                    {
                        Console.Clear();
                        Console.WriteLine("a. Something!\nq. Quit");
                        Console.Write("Choise: ");
                        chInput = char.Parse(Console.ReadLine());

                        switch (chInput)
                        {
                            case 'a':
                                Console.WriteLine("Try again!");
                                break;
                            case 'q':
                                bContinue = false;
                                break;

                            default:
                                Console.WriteLine("Try something else.");
                                break;
                        }
                    }
                }

                else
                {
                    Console.WriteLine("Wrong Password!");
                    iNumberOfTries--;
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    Console.Clear();

                    if (iNumberOfTries == 0)
                    {
                        bContinue = false;
                    }
                }
            }
        }
    }
}
