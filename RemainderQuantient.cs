using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFive
{
    public class RemainderQuantient
    {
        public static void QuanRemainder()
        {
            Console.WriteLine("Enter the dividend :");
            int dividend = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the divisor :");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int quan = dividend / divisor;

            int rem = dividend % divisor;

            Console.WriteLine("Quatient is :" + quan + " Remainder is :" + rem);

        }
    }
}
