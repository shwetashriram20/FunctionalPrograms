
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFive
{
    public class factors
    {
        public static void PrimeFactor(int n)
        {
            while (n % 2 == 0)
            {
                Console.WriteLine("Please enter a number : ");
                n /= 2;

            }
             for (int i =1;i<n; i++)
            {
                while (n %1 ==0)
                {
                    Console.WriteLine(i + "is a prime factor");
                    n /= 1;
                        
                }
            }
            if (n > 2)
                Console.Write(n);
            }
        public static void PrimeFactor()
        {
            int n = 315;
            PrimeFactor(n);
        }
        
    }
}
