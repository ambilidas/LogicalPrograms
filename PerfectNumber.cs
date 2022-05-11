using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PerfectNumber
    {
        public void checkPerfectNumber()
        {
            int sum = 0;
            Console.WriteLine("Enter the number");
            int number=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < number/2; i++)
            {
                if(number%i == 0)
                {
                    sum += i;
                }
            }
            if (sum == number)
            {
                Console.WriteLine(" Entered number is a perfect number");
            }
            else
            {
                Console.WriteLine(" Entered number is not a perfect number");
            }
        }
    }
}
