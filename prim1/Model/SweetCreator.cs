using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21.Model
{
    public class SweetCreator
    {
        public static string[] candyNames = new string[]
        {
                "Snickers", "Skittles", "M&M's", "Twix", "KitKat", "Milky Way"
        };
        public static string[] cookieNames = new string[]
        {
                "Macaron", "Gingerbread", "Biscotti", "Chip", "Macadamia", "Peanut butter"
        };
        public static string[] cheesecakeNames = new string[]
        {
                "Orange", "Apple", "Vanilla", "Strawberry", "Cidar", "Amber"
        };
        public static string[] cupcakeNames = new string[]
        {
                "Brownie", "Chokolate", "Fairy", "Truffle", "Lemon ", "Red Velvet"
        };
        public static Sweet[] CreateSweets(int numberOfSweets)
        {
            Random random = new Random();
            var sweets = new Sweet[numberOfSweets];

            for (int i = 0; i < numberOfSweets; i++)
            {
                int randomSweetType = random.Next(4); // 0 - candies, 1 - cookies, 2 - cheesecakes, 3 - cupcakes

                switch (randomSweetType)
                {
                    case 0:
                        int randomCandyIndex = random.Next(candyNames.Length);
                        string randomCandyName = candyNames[randomCandyIndex];
                        decimal randomCandyPrice = (decimal)random.Next(1, 500) / 100;
                        int randomCandyWeight = random.Next(5, 71);
                        bool randomCandyIsSugarFree = random.Next(2) == 0;

                        sweets[i] = new Candy
                        {
                            Name = randomCandyName,
                            Price = randomCandyPrice,
                            Weight = randomCandyWeight,
                            IsSugarFree = randomCandyIsSugarFree,
                            sweetKind = "Candy"
                        };
                        break;
                    case 1:
                        int randomCookieIndex = random.Next(cookieNames.Length);
                        string randomCookieName = cookieNames[randomCookieIndex];
                        decimal randomCookiePrice = (decimal)random.Next(1, 500) / 100;
                        int randomCookieWeight = random.Next(5, 51);
                        bool randomCookieIsChocolate = random.Next(2) == 0;

                        sweets[i] = new Cookie
                        {
                            Name = randomCookieName,
                            Price = randomCookiePrice,
                            Weight = randomCookieWeight,
                            IsChocolate = randomCookieIsChocolate,
                            sweetKind = "Cookie"
                        };
                        break;
                    case 2:
                        int randomCheesecakeIndex = random.Next(cheesecakeNames.Length);
                        string randomCheesecakeName = cheesecakeNames[randomCheesecakeIndex];
                        decimal randomCheesecakePrice = (decimal)random.Next(200, 900) / 100;
                        int randomCheesecakeWeight = random.Next(50, 301);
                        bool randomCheesecakeIsBacked = random.Next(2) == 0;

                        sweets[i] = new Cheesecake
                        {
                            Name = randomCheesecakeName,
                            Price = randomCheesecakePrice,
                            Weight = randomCheesecakeWeight,
                            IsBacked = randomCheesecakeIsBacked,
                            sweetKind = "Cheesecake"
                        };
                        break;
                    case 3:
                        int randomCupcakeIndex = random.Next(cupcakeNames.Length);
                        string randomCupcakeName = cupcakeNames[randomCupcakeIndex];
                        decimal randomCupcakePrice = (decimal)random.Next(1, 1000) / 100;
                        int randomCupcakeWeight = random.Next(50, 501);
                        bool randomCupcakeIsFrosted = random.Next(2) == 0;

                        sweets[i] = new Cupcake
                        {
                            Name = randomCupcakeName,
                            Price = randomCupcakePrice,
                            Weight = randomCupcakeWeight,
                            IsFrosted = randomCupcakeIsFrosted,
                            sweetKind = "Cupcake"
                        };
                        break;
                }
            }
            return sweets;
        }
    }

} 
    
    
    
    
    
    
    
    //public static Candy[] candies = new Candy[]
                        //       {
                        //            new Candy { Name = "Snickers", Price = 0.99m, Weight = 12, IsSugarFree = true , sweetKind = "Candy" },
                        //            new Candy { Name = "Skittles", Price = 0.49m, Weight = 10,IsSugarFree = false, sweetKind = "Candy" },
                        //            new Candy { Name = "M&M's", Price = 0.75m, Weight = 15,IsSugarFree = false, sweetKind = "Candy" },
                        //            new Candy { Name = "Twix", Price = 1.25m, Weight = 20, IsSugarFree = true, sweetKind = "Candy" },
                        //       };
                        //public static Cookie[] cookies = new Cookie[]
                        //       {
                        //            new Cookie { Name = "Macaron", Price = 0.89m, Weight = 10,IsChocolate = false, sweetKind = "Cookie" },
                        //            new Cookie { Name = "Gingerbread", Price = 1.75m, Weight = 15,IsChocolate = false, sweetKind = "Cookie" },
                        //            new Cookie { Name = "Biscotti", Price = 1.05m, Weight = 20, IsChocolate = true, sweetKind = "Cookie" },
                        //            new Cookie { Name = "Chip", Price = 0.99m, Weight = 14, IsChocolate = true, sweetKind = "Cookie" }
                        //       };

                        //public static Cheesecake[] cheesecakes = new Cheesecake[]
                        //       {
                        //            new Cheesecake { Name = "Orange", Price = 0.89m, Weight = 10,IsBacked = false, sweetKind = "Cheesecake" },
                        //            new Cheesecake { Name = "Apple", Price = 1.75m, Weight = 15,IsBacked = false, sweetKind = "Cheesecake" },
                        //            new Cheesecake { Name = "Vanilla", Price = 1.05m, Weight = 20, IsBacked = true, sweetKind = "Cheesecake" },
                        //            new Cheesecake { Name = "Strawberry", Price = 0.99m, Weight = 14, IsBacked = true, sweetKind = "Cheesecake" }
                        //       };

                        //public static Cupcake[] cupcakes = new Cupcake[]
                        //       {
                        //            new Cupcake { Name = "Brownie", Price = 0.89m, Weight = 10,IsFrosted = false, sweetKind = "Cupcake" },
                        //            new Cupcake { Name = "Chokolate", Price = 1.75m, Weight = 15,IsFrosted = false, sweetKind = "Cupcake" },
                        //            new Cupcake { Name = "Fairy", Price = 1.05m, Weight = 20, IsFrosted = true, sweetKind = "Cupcake" },
                        //            new Cupcake { Name = "Truffle", Price = 0.99m, Weight = 14, IsFrosted = true, sweetKind = "Cupcake" }
                        //       };

                        //public Sweet[] sweets = candies.Cast<Sweet>().Concat(cookies.Cast<Sweet>()).Concat(cheesecakes.Cast<Sweet>()).Concat(cupcakes.Cast<Sweet>()).ToArray();

                //}
//}
