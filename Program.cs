using System;

namespace LogicalPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Welcome to Logical Programs");
            bool option=true;
            while (option == true)
            {
                Console.WriteLine("\nWhich program do you want to execute ?");
                Console.WriteLine("Q1.Fibonacci Series");
                Console.WriteLine("Q2.Prime Number");
                Console.WriteLine("Q3.Perfect Number");
                Console.WriteLine("Q4.Reverse Number");
                Console.WriteLine("Q5.Stop Watch Problem");
                Console.WriteLine("Q6.Coupon Numbers");
                Console.WriteLine("Please enter the question number for executing program");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You have choosen Q1.Fibonacci Series");
                        FibonacciSeries obj1 = new FibonacciSeries();
                        obj1.fib();
                        break;
                    case 2:
                        Console.WriteLine("You have choosen Q2.Prime Number");
                        PrimeNumber obj2 = new PrimeNumber();
                        obj2.checkPrimeNumber();
                        break;
                    case 3:
                        Console.WriteLine("You have choosen Q3.Perfect Number");
                        PerfectNumber obj3 = new PerfectNumber();
                        obj3.checkPerfectNumber();
                        break;
                    case 4:
                        Console.WriteLine("You have choosen Q4.Reverse Number");
                        ReverseNumber obj4 = new ReverseNumber();
                        obj4.reverseNum();
                        break;
                    case 5:
                        Console.WriteLine("You have choosen Q5.Stop Watch Problem");
                        StopWatch obj5 = new StopWatch();
                        obj5.stopWatchSimulation();
                        break;
                    case 6:
                        Console.WriteLine("You have choosen Q6.Coupon Numbers");
                        CouponNumbers obj6 = new CouponNumbers();
                        obj6.couponNumber();
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;


                }
            }
        }
            
    }


}
