using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab21.Model;

namespace Lab21.View
{
    public class Gift
    {
        public static int countSweets;




        public static void PrintGiftList(Sweet[] sweets)
        {
            countSweets = sweets.Count();
            int choice = 0;
                try
                {
                    Console.WriteLine("Enter the number of prefered sorting:\n\t1. Price Ascending \n\t2. Price Descending \n\t and any other to skip this step");
                    string input = Console.ReadLine();
                    choice = int.Parse(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Only natural numbers! Try again!");
                }
            
            switch (choice)
            {
                case 1: { Array.Sort(sweets, new PriceAscendingComparer()); break; }
                case 2: { Array.Sort(sweets, new PriceDescendingComparer()); break;}
                default: { Console.WriteLine("You chose to skip sorting!"); break; }
            }

            Console.WriteLine("\n\n\t\tGiftList:");
            Console.WriteLine("\t\t-----------");


            for (int i = 0; i < countSweets; i++)
            {
                Sweet sweet = sweets[i];
                Console.Write("\n{0}:", i + 1);
                if (sweet is Cookie cookie && !(sweet is CookieFortune cookief))
                {
                    cookie.print(cookie);
                }
                else if (sweet is Candy candy)
                {
                    candy.print(candy);
                }
                else if (sweet is Cheesecake cheesecake)
                {
                    cheesecake.print(cheesecake);
                }
                else if (sweet is Cupcake cupcake)
                {
                    cupcake.print(cupcake);
                }
                else if (sweet is CookieFortune cookieF)
                {
                    cookieF.print(cookieF);
                }
            }

            Console.WriteLine("\n");
        }
    }
}
