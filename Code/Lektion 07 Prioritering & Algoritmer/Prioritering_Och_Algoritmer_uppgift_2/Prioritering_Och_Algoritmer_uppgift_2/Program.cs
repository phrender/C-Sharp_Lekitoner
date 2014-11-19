using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prioritering_Och_Algoritmer_uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and initialize number of minutes and number of texts per month
            int iNumCallMinutesMonth = 0;
            int iNumSmsMonth = 0;

            // Create and initialize prices for Telia
            float fTeliaMinPrice = 0.69f;
            float fTeliaSmsPrice = 0.69f;

            // Create and initialize prices for Tele2
            float fTele2MinPrice = 0.59f;
            float fTele2SmsPrice = 0.59f;

            // Create and initialize the total costs for Telia and Tele2
            float fTeliaTotalCost = 0.0f;
            float fTele2TotalCost = 0.0f;

            // Let the user enter the number of minutes they talk per month
            Console.Write("Enter the number of minutes per month: ");
            iNumCallMinutesMonth = int.Parse(Console.ReadLine());

            // Let the user enter the number of texts the send per month
            Console.Write("Enter the number of texts per months: ");
            iNumSmsMonth = int.Parse(Console.ReadLine());

            // Calculate the cost for the number of minutes per month
            fTeliaTotalCost = fTeliaMinPrice * iNumCallMinutesMonth;
            fTele2TotalCost = fTele2MinPrice * iNumCallMinutesMonth;

            // Calculate the cost for the texts per months
            fTeliaTotalCost += fTeliaSmsPrice * iNumSmsMonth;
            fTele2TotalCost += fTele2SmsPrice * iNumSmsMonth;


            // Show the user the results
            Console.WriteLine("Cost with Telia: {0}kr/month", fTeliaTotalCost);
            Console.WriteLine("Cost with Tele2: {0}kr/month", fTele2TotalCost);
        }
    }
}
