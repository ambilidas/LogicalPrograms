using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LogicalPrograms
{
    internal class StopWatch
    {
		public void stopWatchSimulation()
		{
            Console.WriteLine("To start the stopwatch enter S/s: ");
			char start=Convert.ToChar(Console.ReadLine());
			Stopwatch stopwatch = Stopwatch.StartNew();
			if(start=='S' || start == 's')
            {
				// Begin timing
				stopwatch.Start();
                Console.WriteLine("To stop the stopwatch enter Q/q: ");
				char end = Convert.ToChar(Console.ReadLine());
				if (end == 'Q' || end == 'q')
				{
					// Stop timing
					stopwatch.Stop();
					// Write result
					Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
				}   
			}
			else
			{
				Console.WriteLine("Invalid input");

			}

		}
	}
}
