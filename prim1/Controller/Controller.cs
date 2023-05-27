using System;
using Lab21.Model;
using Lab21.View;

class Controller
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello!");

        int amount = 0;
        bool validInput = false;

        while (!validInput || amount <= 0)
        {
            Console.Write("Enter the amount of sweets: ");
            string input = Console.ReadLine();
            if (amount <= 0) Console.WriteLine("Please, you can't have {0} sweets in your gift, could you?", input);

            try
            {
                amount = int.Parse(input);
                validInput = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Only natural numbers! Try again!");
            }
        }

        // Обращаемся к переменной sweets через экземпляр класса SweetCreator
        Sweet[] sweets = SweetCreator.CreateSweets(amount);

        Gift.PrintGiftList(sweets);

        Console.WriteLine("\nThe cheapest one is {0}", (Manager.FindCheapestSweet(sweets)).Name);
        Console.WriteLine("The most expensive one is {0}", (Manager.FindMostExpensiveSweet(sweets)).Name);
        Console.WriteLine("The total price is {0} byn", Manager.CalculateTotalPrice(sweets));
        Console.WriteLine("The total weight is {0} kg", Manager.CalculateTotalWeight(sweets)/1000);
    }
}
