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

            Console.WriteLine("Gift List:");
            Console.WriteLine("-----------");

            for (int i = 0; i < countSweets; i++)
            {
                Sweet sweet = sweets[i];
                Console.Write("{0}: {1} - {2} byn, {3}, ", i + 1, sweet.Name, sweet.Price, sweet.sweetKind);
                if (sweet is Cookie cookie)
                {
                    Console.WriteLine(" {0}", cookie.IsChocolate ? "chocolate" : "non-chocolate");
                }
                else if (sweet is Candy candy)
                {
                    Console.WriteLine(" {0}", candy.IsSugarFree ? "sugar-free" : "full of sugar");
                }
                else if (sweet is Cheesecake cheesecake)
                {
                    Console.WriteLine(" {0}", cheesecake.IsBacked ? "was backed" : "wasn't baked");
                }
                else if (sweet is Cupcake cupcake)
                {
                    Console.WriteLine(" {0}", cupcake.IsFrosted ? "has frosting" : "doesn't have frosting");
                }
            }

        }
    }
}
