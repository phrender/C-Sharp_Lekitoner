using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace If_Statements_uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bIsStudent = false;
            bool bIsElderly = false;
            float fTicketPrice = 0.0f;
            int iAge = 0;
            char chAnswer = '\0';

            Console.Write("Enter the ticket price: ");
            fTicketPrice = float.Parse(Console.ReadLine());

            Console.WriteLine("Are you a student or elderly? y/n");
            Console.Write("Enter answer: ");
            chAnswer = char.Parse(Console.ReadLine());

            if (chAnswer == 'n' &&(!bIsElderly && !bIsStudent))
            {
                Console.Clear();
                Console.Write("Enter age: ");
                iAge = int.Parse(Console.ReadLine());

                if ((iAge >= 18) || (iAge <= 65))
                {
                    Console.WriteLine("You pay: {0}", fTicketPrice);
                }

                else if (iAge < 18)
                {
                    fTicketPrice = fTicketPrice * 0.85f;
                    Console.WriteLine("You get a child discount and pay: {0}", fTicketPrice);
                }

                else if (iAge > 65 && iAge < 99)
                {
                    fTicketPrice = fTicketPrice * 0.75f;
                    Console.WriteLine("You should have selected 'Yes' when asked for ");
                }

                else
                {
                    Console.WriteLine("You should not exist anymore...");
                }
            }

            else if (bIsStudent)
            {
                fTicketPrice *= 0.75f;
                Console.WriteLine("You are a student and pay: {0}", fTicketPrice);
            }

            else if (bIsElderly)
            {
                fTicketPrice *= 0.75f;
                Console.WriteLine("You are elderly and pay: {0}", fTicketPrice);
            }

            else
            {
                Console.WriteLine("Error: Invalid choise!");
            }

        }
    }
}
