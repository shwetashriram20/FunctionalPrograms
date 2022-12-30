using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFive
{
    public class LeapYear
    {
        public static void CalculateLeapYear()
        {
            Console.WriteLine("Enter the year: ");

            int year = Convert.ToInt32(Console.ReadLine());
            
            if (year > 999 && year < 9999)
            {
                {
                    if (year % 4 == 0)
                    {
                        Console.WriteLine("{0} is Leap year", year);
                    }
                }
            }
            else
            {
                Console.WriteLine("Enter the 4 digit number of year");
            }
        }
    }

}
