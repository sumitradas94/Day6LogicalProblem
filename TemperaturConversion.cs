using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logial_Problem
{
    public class TemperaturConversion
    {
        public static void DegreeConverse()
        {
            double celsi, fahren;
            Console.WriteLine("\n***************Degree converse****************\n ");
            Console.WriteLine("ENTER THE NUMBER TO CONVERSE TEMP \n 1)FOR TO CONVERT INTO CELSIUS \t 2)FOR TO COVERT INTO FAHRENHEIT ");
            int inp = Convert.ToInt32(Console.ReadLine());
            switch (inp)
            {
                case 1:
                    Console.WriteLine("ENTER THE FAHREHIET TEMPARATURE");
                    fahren = Convert.ToDouble(Console.ReadLine());
                    celsi = (fahren - 32) * 5 / 9;
                    Console.WriteLine("THE CELSIUS IS: " + celsi);
                    break;
                case 2:
                    Console.WriteLine("ENTER THE CELSIUS TEMPARATURE");
                    celsi = Convert.ToDouble(Console.ReadLine());
                    fahren = (celsi * 9 / 5) + 32;
                    Console.WriteLine("THE FAHREHIET IS: {0}", fahren);
                    break;
            }
        }
    }
}
