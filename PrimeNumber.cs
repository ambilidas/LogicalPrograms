using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PrimeNumber
    {
        public void checkPrimeNumber()
        {
            int test = 0;
            Console.WriteLine("\nEnter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= number/2; i++)
            {
                if (number % i == 0)
                {
                    test = 1;
                    break;
                }
            }
            if(test == 0)
            {
                Console.WriteLine("The number {0} is a prime number", number);
            }
            else
            {
                Console.WriteLine("The number {0} is not a prime number", number);
            }
            
            
        }

    }  
}
