using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PerfectNum
    {
        public static void CheckPerfectNum()
        {
            int mx, mn, n, sum, i;
            Console.WriteLine("Find the Perfect number within the given range ");

            Console.WriteLine("Enter the starting range or number : ");
            mn = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the ending range or number : ");
            mx = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The Perfect number within the given range are :");
            for (n=mn;n<=mx;n++)
            {
                i= 1;
                sum = 0;
                while(i<n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                      i++;
                        
                }
                if (sum == n)
                    Console.Write(" " + n);
            }

            //int sum = 0;
            //for(int i=1; i<num; i++)
            //{
            //    if(num % i == 0)
            //    {
            //        sum += i;
            //    }
            //}
            
            //if(sum == num)
            //{
            //    Console.WriteLine("The Enter number is Perfect number");
            //}
            //else
            //{
            //    Console.WriteLine("The Enter number is not Perfect number");
            //}
        }
    }
}
