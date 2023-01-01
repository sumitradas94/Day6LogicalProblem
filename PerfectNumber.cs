using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logial_Problem
{
    public class PerfectNumber
    {
        public static void checkperfectno()
        {
            int sum = 0;
            Console.WriteLine("Enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                    Console.WriteLine("factor of num is:" + sum);
                }
            }
            if (sum == num)
            {
                Console.WriteLine("num is perfect number");
            }
            else
            {
                Console.WriteLine("num is not a perfect number");
            }
        }
    }
}
