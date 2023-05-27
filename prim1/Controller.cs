using System;
using Lab21;

class Controller
{
    static void Main(string[] args)
    { 
        Candy[] candies = new Candy[]
        {
            new Candy { Name = "Snickers", Price = 0.99m, Weight = 12, IsSugarFree = true },
            new Candy { Name = "Skittles", Price = 0.49m, Weight = 10,IsSugarFree = false },
            new Candy { Name = "M&M's", Price = 0.75m, Weight = 15,IsSugarFree = false },
            new Candy { Name = "Twix", Price = 1.25m, Weight = 20, IsSugarFree = true },
            new Candy { Name = "KitKat", Price = 0.99m, Weight = 14, IsSugarFree = true },
        };
        Cookie[] cookies = new Cookie[]
        {
                new Cookie { Name = "Macaron", Price = 0.89m, Weight = 10,IsChocolate = false },
                new Cookie { Name = "Gingerbread", Price = 1.75m, Weight = 15,IsChocolate = false },
                new Cookie { Name = "Biscotti", Price = 1.05m, Weight = 20, IsChocolate = true },
                new Cookie { Name = "Chip", Price = 0.99m, Weight = 14, IsChocolate = true }
        };

        Sweet[] sweets = candies.Cast<Sweet>().Concat(cookies.Cast<Sweet>()).ToArray();

        Gift.PrintGiftList(sweets);

        Console.WriteLine("\nThe cheapest one is {0}", (Gift.FindCheapestSweet(sweets)).Name);
        Console.WriteLine("The most expensive one is {0}", (Gift.FindMostExpensiveSweet(sweets)).Name);
        Console.WriteLine("The total price is {0} byn", Gift.CalculateTotalPrice(sweets));
        Console.WriteLine("The total weight is {0} kg", Gift.CalculateTotalWeight(sweets)/1000);
    }
}
