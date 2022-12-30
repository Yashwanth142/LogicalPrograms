﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class FibonacciSeries
    {
        public static void Fibonacci()
        {
            Console.WriteLine("Enter the number of Elements :");
            int num = Convert.ToInt32(Console.ReadLine());
            int n1 = 0;
            int n2 = 1;
            int n3;

            Console.Write(n1 + " " + n2 + " ");
            

            for(int i = 2; i < num; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
