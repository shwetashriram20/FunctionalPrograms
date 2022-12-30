using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFive
{
    public class VowelConsontant
    {
        public static void CheckVowelConsontant()
        {
            Console.WriteLine("Enter a alphabet : ");
            char ch = Convert.ToChar(Console.ReadLine());
           
                switch (ch)
            {
                case 'a':
                    Console.WriteLine("the Alphabet is Vowel");
                    break;
                case 'i':
                    Console.WriteLine("the Alphabet is Vowel");
                    break;

                case 'o':
                    Console.WriteLine("The Alphabet is Vowel"); 
                    break;

                case 'u':
                    Console.WriteLine("The Alphabet is Vowel");
                    break;
                
                case 'e':
                    Console.WriteLine("The Alphabet is Vowel");
                    break;
               
                default:
                    Console.WriteLine("The Alphabet is not Vowel");
                    break;

            
            }
        }
    }
}

