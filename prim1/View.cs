using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21
{
    public class Gift
    {
        public static void PrintGiftList(Sweet[] sweets)
        {
            Console.WriteLine("Gift List:");
            Console.WriteLine("-----------");

            for (int i = 0; i < 9; i++)
            {
                Sweet sweet = sweets[i];
                Console.Write("{0}: {1} {2} byn", i + 1, sweet.Name, sweet.Price);
                if (sweet is Cookie cookie)
                {
                    Console.WriteLine(" {0}", cookie.IsChocolate ? "chocolate" : "non-chocolate");
                }
                else if (sweet is Candy candy)
                {
                    Console.WriteLine(" {0}", candy.IsSugarFree ? "sugar-free" : "full of sugar");
                }
            }

        }

        public static Sweet FindCheapestSweet(Sweet[] sweets)
        {
            Sweet cheapestSweet = sweets[0];

            foreach (Sweet sweet in sweets)
            {
                if (sweet.Price < cheapestSweet.Price)
                {
                    cheapestSweet = sweet;
                }
            }

            return cheapestSweet;
        }

        public static Sweet FindMostExpensiveSweet(Sweet[] sweets)
        {
            Sweet mostExpensiveSweet = sweets[0];

            foreach (Sweet sweet in sweets)
            {
                if (sweet.Price > mostExpensiveSweet.Price)
                {
                    mostExpensiveSweet = sweet;
                }
            }

            return mostExpensiveSweet;
        }

        public static decimal CalculateTotalPrice(Sweet[] sweets)
        {
            decimal totalPrice = 0m;

            foreach (Sweet sweet in sweets)
            {
                totalPrice += sweet.Price;
            }

            return totalPrice;
        }

        public static double CalculateTotalWeight(Sweet[] sweets)
        {
            double totalWeight = 0;

            foreach (Sweet sweet in sweets)
            {
                totalWeight += sweet.Weight;
            }

            return totalWeight;
        }
    }
}
