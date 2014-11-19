using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prioritering_Och_Algoritmer_uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and initialize three variables to handle our numbers
            float fIncomeBeforeTax = 0.0f;
            float fTaxes = 0.7f;
            float fIncomeAfterTax = 0.0f;

            // Let the user enter thier income before tax
            Console.Write("Enter your salery: ");
            fIncomeBeforeTax = float.Parse(Console.ReadLine());

            // Calculate the remaining salery after taxes if the taxation rate is 30%
            fIncomeAfterTax = fIncomeBeforeTax * fTaxes;

            // Tell the user how much money the have after taxes
            Console.WriteLine("You have {0} left after taxes.", fIncomeAfterTax);
        }
    }
}
