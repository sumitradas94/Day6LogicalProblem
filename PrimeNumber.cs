using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logial_Problem
{
    public class PrimeNumber
    {
        public static void checkprimeno()
            {
                Console.WriteLine("Enter the Number:");
                int num = Convert.ToInt32(Console.ReadLine());
                int count = 0;
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine("num is prime number");
                }
                else
                {
                    Console.WriteLine("num is not a prime number");
                }
            }
        }
    }


