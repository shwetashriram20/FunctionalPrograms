using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFive
{
    public class harmonic
    {
        public static void HarmonicValue()
        {
            Console.WriteLine("Enter the Harmonic Value : ");

            int h = Convert.ToInt32(Console.ReadLine());

            double n= 0.0;
            for(double i=1;i<=h;i++)
                {
                n = n + (1 / i);
            }
                Console.WriteLine("Enter the 4 digit number of year");
            
        }
    }
}

