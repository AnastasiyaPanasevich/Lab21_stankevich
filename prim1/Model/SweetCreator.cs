using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21.Model
{
    public class SweetCreator
    {
        public int amountOfCandies = 5;
        public int amountOfCookies = 5;
        public int amountOfCheesecakes = 5;
        public int amountOfCupcakes = 5;

        public static string[] candyNames = new string[]
        {
            "Snickers",
            "Skittles",
            "M&M's",
            "Twix",
            "KitKat",
            "Milky Way"
        };

        public static Candy[] candies1 (int amount)
        {
            Random random = new Random();
            var candies = new Candy[amount];

            for (int i = 0; i < amount; i++)
            {
                int randomNameIndex = random.Next(0, candyNames.Length);
                string randomName = candyNames[randomNameIndex];
                decimal randomPrice = (decimal)random.Next(1, 500) / 100;
                int randomWeight = random.Next(1, 51);
                bool randomIsSugarFree = random.Next(2) == 0;

                candies[i] = new Candy
                {
                    Name = randomName,
                    Price = randomPrice,
                    Weight = randomWeight,
                    IsSugarFree = randomIsSugarFree,
                    sweetKind = "Candy"
                };
            }

            return candies;
        }


        //public static Candy[] candies = new Candy[]
        //       {
        //            new Candy { Name = "Snickers", Price = 0.99m, Weight = 12, IsSugarFree = true , sweetKind = "Candy" },
        //            new Candy { Name = "Skittles", Price = 0.49m, Weight = 10,IsSugarFree = false, sweetKind = "Candy" },
        //            new Candy { Name = "M&M's", Price = 0.75m, Weight = 15,IsSugarFree = false, sweetKind = "Candy" },
        //            new Candy { Name = "Twix", Price = 1.25m, Weight = 20, IsSugarFree = true, sweetKind = "Candy" },
        //       };
        public static Cookie[] cookies = new Cookie[]
               {
                    new Cookie { Name = "Macaron", Price = 0.89m, Weight = 10,IsChocolate = false, sweetKind = "Cookie" },
                    new Cookie { Name = "Gingerbread", Price = 1.75m, Weight = 15,IsChocolate = false, sweetKind = "Cookie" },
                    new Cookie { Name = "Biscotti", Price = 1.05m, Weight = 20, IsChocolate = true, sweetKind = "Cookie" },
                    new Cookie { Name = "Chip", Price = 0.99m, Weight = 14, IsChocolate = true, sweetKind = "Cookie" }
               };

        public static Cheesecake[] cheesecakes = new Cheesecake[]
               {
                    new Cheesecake { Name = "Orange", Price = 0.89m, Weight = 10,IsBacked = false, sweetKind = "Cheesecake" },
                    new Cheesecake { Name = "Apple", Price = 1.75m, Weight = 15,IsBacked = false, sweetKind = "Cheesecake" },
                    new Cheesecake { Name = "Vanilla", Price = 1.05m, Weight = 20, IsBacked = true, sweetKind = "Cheesecake" },
                    new Cheesecake { Name = "Strawberry", Price = 0.99m, Weight = 14, IsBacked = true, sweetKind = "Cheesecake" }
               };

        public static Cupcake[] cupcakes = new Cupcake[]
               {
                    new Cupcake { Name = "Brownie", Price = 0.89m, Weight = 10,IsFrosted = false, sweetKind = "Cupcake" },
                    new Cupcake { Name = "Chokolate", Price = 1.75m, Weight = 15,IsFrosted = false, sweetKind = "Cupcake" },
                    new Cupcake { Name = "Fairy", Price = 1.05m, Weight = 20, IsFrosted = true, sweetKind = "Cupcake" },
                    new Cupcake { Name = "Truffle", Price = 0.99m, Weight = 14, IsFrosted = true, sweetKind = "Cupcake" }
               };

        public Sweet[] sweets = candies.Cast<Sweet>().Concat(cookies.Cast<Sweet>()).Concat(cheesecakes.Cast<Sweet>()).Concat(cupcakes.Cast<Sweet>()).ToArray();

    }
}
