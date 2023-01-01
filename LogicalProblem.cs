using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logial_Problem
{
    public class LogicalProblem
    {
        public static void checkfibonacci()
        {
            Console.WriteLine("Enter Number of element:");
            int num = Convert.ToInt32(Console.ReadLine());
            int num1 = 0;
            int num2 = 1;
            Console.WriteLine(num1 + "" + num2 + "");
            for (int i = 0; i < num; i++)
            {
                int num3 = num1 + num2;
                Console.WriteLine(num3 + "");
                num1 = num2;
                num2 = num3;

            }
        }
    }
}
