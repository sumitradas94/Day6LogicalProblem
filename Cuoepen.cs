using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logial_Problem
{
    public class Cuoepen
    {
        public static void Cuoe()
        {
            Console.WriteLine("\n***************Distnict Cuoepn number****************\n ");
            Console.WriteLine("enter a number of distinct values: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] Arr = new int[n];
            int i = 1;
            int count = 0;
            var random = new Random();
            int j = 0;
            Console.WriteLine();

            for (i = 1; i < n; i++)
            {
                var random_number = random.Next(1, n);
                if (Arr.Contains(random_number))
                {
                    i--;
                }
                else
                {
                    Arr[i] = random_number;
                }
                count++;

            }
            Console.WriteLine("COUNT IS :{0} ", count);
            for (j = 0; j < Arr.Length; j++)
            {
                Console.WriteLine("array is:{0} ", Arr[j]);
            }
        }
    }
}
