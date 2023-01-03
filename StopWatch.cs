using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logial_Problem
{
    public class StopWatch
    {
        public static void Stop()
        {
            Console.WriteLine("\n***************Stop Watch****************\n ");
            Console.WriteLine("Press Enter to Start.");
            Console.ReadLine();
            DateTime Start = DateTime.Now;

            Console.WriteLine("Press Enter to Stop.");
            Console.ReadLine();
            DateTime Stop = DateTime.Now;

            Console.Write("Elapsed Time = " + (Stop - Start));
        }
    }
}
