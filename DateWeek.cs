using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logial_Problem
{
    public class DateWeek
    {
        public static void dayOfWeek()
        {
            int m = 0, j = 12;
            string[] days = new string[7] { "Sunday", "Monday", "Tuesday", "Wednesday", "thursday", "friday", "saturday" };
            string[] month = new string[12] { "jan", "feb", "mar", "apr", "may", "jun", "jul", "aug", "sep", "oct", "nov", "dec" };
            System.Console.WriteLine("enter the date (1-31) : ");
            int d = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("enter the Month with formate of first three letters small (Example: jan,feb,mar ....) ");
            string n = Console.ReadLine();
            for (int i = 0; i < j; i++)
            {
                if (n == month[i])
                    m = i + 1;
            }


            Console.WriteLine("enter the year : ");
            int y = Convert.ToInt32(Console.ReadLine());
            if (d >= 1 && m >= 1 && y >= 1000 && d <= 31 && m <= 12 && y <= 10000)
            {
                int y0 = y - (14 - m) / 12;
                int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
                int m0 = m + 12 * ((14 - m) / 12) - 2;
                int d0 = (d + x + 31 * m0 / 12) % 7;
                Console.WriteLine("The day on this date is: " + days[d0]);
            }
            else
                Console.WriteLine("enter the valid date");
        }
    }
}
