﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NestedFor_uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 
            int[,] a = new int[5, 2] { { 0, 0 }, { 1, 2 }, { 2, 4 }, { 3, 6 }, { 4, 8 } };

            int i, j;

            
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0},{1}] = {2}", i, j, a[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}
