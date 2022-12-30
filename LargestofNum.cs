using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFive
{
    public class LargestofNum
    {
        public static void LargestNumber()
        {
            Console.WriteLine("Enter the first number : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number : ");
            int c = Convert.ToInt32(Console.ReadLine());

            if(a>b & a>c)
            {
                Console.WriteLine("the Largest number is : " +a) ;
            }
            else if (b>c &b>a)
            {
                Console.WriteLine("the Largest number is : " +b);
            }
            else 
            {
                Console.WriteLine("the Largest number is : " +c);

            }
        }
    }
}

