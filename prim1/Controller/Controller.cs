using System;
using Lab21.Model;
using Lab21.View;

class Controller
{
    static void Main(string[] args)
    {
        // Создаем экземпляр класса SweetCreator
        SweetCreator sweetCreator = new SweetCreator();

        // Обращаемся к переменной sweets через экземпляр класса SweetCreator
        Sweet[] sweets = sweetCreator.sweets;

        Gift.PrintGiftList(sweets);

        Console.WriteLine("\nThe cheapest one is {0}", (Manager.FindCheapestSweet(sweets)).Name);
        Console.WriteLine("The most expensive one is {0}", (Manager.FindMostExpensiveSweet(sweets)).Name);
        Console.WriteLine("The total price is {0} byn", Manager.CalculateTotalPrice(sweets));
        Console.WriteLine("The total weight is {0} kg", Manager.CalculateTotalWeight(sweets)/1000);
    }
}
