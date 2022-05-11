using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseNumber
    {
        public void reverseNum()
        {
            int number, reverse = 0, remainder;
            Console.WriteLine("Enter the number : ");
            number=Convert.ToInt32(Console.ReadLine());
            while (number != 0)
            {
                remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number /= 10;
            }
            Console.WriteLine("Reversed number is: "+reverse);
        }
    }
}
