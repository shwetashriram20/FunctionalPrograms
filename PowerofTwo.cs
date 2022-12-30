using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFive
{
    public class powerOf2
    {

        public static void power()
        {
            int i;
            int powerofTwo = 1;
            Console.WriteLine("Enter the number: ");
            int N = Convert.ToInt32(Console.ReadLine());

            if (0 <= N && N < 31)
            {
                for (i = 1; i <= N; i++)
                {
                    powerofTwo = 2 * powerofTwo;
                }

                Console.WriteLine("Power of Two is :" + powerofTwo);

            }
            else
            {
                Console.WriteLine("Number is greater than 31 .");
            }
        }
    }
}
