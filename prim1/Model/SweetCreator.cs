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
                int randomSweetType = random.Next(5); // 0 - candies, 1 - cookies, 2 - cheesecakes, 3 - cupcakes 4 - fortune cookie

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
                    case 4:
                        randomCookieIndex = random.Next(cookieNames.Length);
                        randomCookieName = cookieNames[randomCookieIndex];
                        randomCookiePrice = (decimal)random.Next(1, 500) / 100;
                        randomCookieWeight = random.Next(5, 51);
                        randomCookieIsChocolate = random.Next(2) == 0;
                        bool randomCookieHasAnswer = random.Next(2) == 0;

                        sweets[i] = new CookieFortune
                        {
                            Name = randomCookieName,
                            Price = randomCookiePrice,
                            Weight = randomCookieWeight,
                            IsChocolate = randomCookieIsChocolate,
                            HasAnswer = randomCookieHasAnswer,
                            sweetKind = "Fortune Cookie"
                        };
                        break;
                }
            }
            return sweets;
        }
    }
} 