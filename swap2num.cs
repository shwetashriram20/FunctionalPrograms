using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFive
{
    public class swap2num
    {
        public static void swapNum()
        {
            Console.WriteLine("Enter the first number: ");

            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the secound number: ");

            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swap the two number a: " + a + " b :" + b);
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("After swap the two number a: " + a + " b :" + b);

        }
    }
}