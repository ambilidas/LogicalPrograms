using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class FibonacciSeries
    {
        public void fib()
        {
            Console.WriteLine("Enter the limit of series ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] f = new int[n + 2];
            int i;
            f[0] = 0;
            f[1] = 1;
            Console.Write(f[0] + " " + f[1]);
            for (i = 2; i <= n; i++)
            {
                f[i] = f[i - 1] + f[i - 2];
                Console.Write(" " + f[i]);
            }
        }
    }
}
