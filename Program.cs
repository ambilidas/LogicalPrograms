using System;

namespace LogicalPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Welcome to Logical Programs");
           FibonacciSeries obj1 = new FibonacciSeries();
           //obj1.fib();
           PrimeNumber obj2=new PrimeNumber();
            //obj2.primeNumberSeries();
            PerfectNumber obj3 = new PerfectNumber();
            //obj3.checkPerfectNumber();
            ReverseNumber obj4 = new ReverseNumber();
            obj4.reverseNum();
        }
    }


}
