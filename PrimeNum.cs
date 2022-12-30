using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNum
    {
        public static void Primenum() 
        {
            Console.WriteLine("Enter a number :");
            int num = Convert.ToInt32(Console.ReadLine());
            int p=0;
            for (int i=2 ; i<=num/2 ; i++)
            {
                if(num%i==0)
                {
                    Console.WriteLine("The Enter number is not Prime number");
                    p = 1;
                    break;
                }
            }
            if (p == 0)
            {
                Console.WriteLine("The Enter number is Prime number");
            }
            
        }
    }
}
