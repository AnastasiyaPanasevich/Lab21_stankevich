// buisness logics
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21.Model
{
    internal class Manager
    {
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
