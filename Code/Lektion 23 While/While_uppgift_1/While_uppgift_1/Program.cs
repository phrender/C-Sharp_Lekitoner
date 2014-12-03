using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace While_uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int iCounter = 0;
            string strContinue = string.Empty;

            while (iCounter < 10)
            {
                strContinue = Console.ReadLine();

                if (strContinue.Equals(""))
                {
                    iCounter++;
                    Console.WriteLine("iCount = {0}", iCounter);
                }
            }
        }
    }
}
