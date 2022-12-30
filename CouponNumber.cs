using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class CouponNumber
    {
        public static void CouponNum()
        {
           int distinct = 0,count=0;
            Console.WriteLine("Enter the number of distnict coupons");
            int couponnum=Convert.ToInt32(Console.ReadLine());

            bool[] isCollect = new bool[couponnum];

            while(distinct<couponnum)
            {
                Random random= new Random();
                int newCoupon = (int)random.Next(couponnum);

                count++;

                if (!isCollect[newCoupon])
                {
                    distinct++;
                    isCollect[newCoupon] = true;
                }
            }
            Console.WriteLine("Total random number needed to have all distinct coupons : " + count);
        }
    }
}
