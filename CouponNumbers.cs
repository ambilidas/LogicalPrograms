using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class CouponNumbers
    {
        public void couponNumber()
        {
            Console.WriteLine("\nEnter the number of coupons : ");
            int num=Convert.ToInt32(Console.ReadLine());
            string coupons=string.Empty;
            while (num > 0)
            {
                int random=new Random().Next(1,100);
                coupons += random;
                num--;
            }
            Console.WriteLine("Your coupon number is " + coupons);
           
        }
    }
}
