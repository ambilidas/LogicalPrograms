using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PrimeNumber
    {
        public void primeNumberSeries()
        {
            bool notPrime = false;
            int j;

            Console.WriteLine("Enter your Target?");
            int target = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= target; i++)
            {
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        notPrime = true;
                        break;
                    }
                }

                if (!notPrime)
                    Console.Write(" "+j);
                else
                    notPrime = false;
            }

        }

    }  
}
