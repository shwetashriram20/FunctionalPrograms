
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFive
{
    public class FlipCoin
    {
        public static void CalcualatePercentage()
        {
            Console.WriteLine("Please enter the value for number of flips");
            int flips = Convert.ToInt32(Console.ReadLine());

            if (flips > 0)
            {
                for (int i = 0; i < flips; i++)
                    Console.WriteLine("MyCoins");
            }
            else
            {
                Console.WriteLine("Please enter the correct number");

            }
        }
    }
}
