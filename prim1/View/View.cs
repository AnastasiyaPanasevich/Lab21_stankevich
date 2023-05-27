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
        public static string FormatSweet(Sweet sweet)
        {
            if (sweet is Cookie cookie && !(sweet is CookieFortune cookie1))
            {
                return string.Format("{0}\t{1} byn\t{2}\t{3}", sweet.Name.PadRight(15), sweet.Price.ToString().PadRight(5), sweet.sweetKind.PadRight(10), cookie.IsChocolate ? "chocolate".PadRight(15) : "non-chocolate".PadRight(15));
            }
            else if (sweet is Candy candy)
            {
                return string.Format("{0}\t{1} byn\t{2}\t{3}", sweet.Name.PadRight(15), sweet.Price.ToString().PadRight(5), sweet.sweetKind.PadRight(10), candy.IsSugarFree ? "sugar-free".PadRight(15) : "full of sugar".PadRight(15));
            }
            else if (sweet is Cheesecake cheesecake)
            {
                return string.Format("{0}\t{1} byn\t{2}\t{3}", sweet.Name.PadRight(15), sweet.Price.ToString().PadRight(5), sweet.sweetKind.PadRight(10), cheesecake.IsBacked ? "was backed".PadRight(15) : "wasn't baked".PadRight(15));
            }
            else if (sweet is Cupcake cupcake)
            {
                return string.Format("{0}\t{1} byn\t{2}\t{3}", sweet.Name.PadRight(15), sweet.Price.ToString().PadRight(5), sweet.sweetKind.PadRight(10), cupcake.IsFrosted ? "has frosting".PadRight(15) : "doesn't have frosting".PadRight(15));
            }
            else if (sweet is CookieFortune cookieF)
            {
                return string.Format("{0}\t{1} byn\t{2}\t{3}\t{4}", sweet.Name.PadRight(15), sweet.Price.ToString().PadRight(5), sweet.sweetKind.PadRight(10), cookieF.IsChocolate ? "chocolate".PadRight(15) : "non-chocolate".PadRight(15), cookieF.HasAnswer ? "the answer is yes".PadRight(15) : "the answer is no".PadRight(15));
            }
            else
            {
                return string.Empty;
            }
        }

        public static void PrintGiftList(Sweet[] sweets)
        {
            countSweets = sweets.Count();

            Console.WriteLine("\n\n\t\tGiftList:");
            Console.WriteLine("\t\t-----------");

            for (int i = 0; i < countSweets; i++)
            {
                Sweet sweet = sweets[i];
                string formattedSweet = FormatSweet(sweet);
                if (!string.IsNullOrEmpty(formattedSweet))
                {
                    Console.WriteLine("{0}: \t{1}", i + 1, formattedSweet);
                }
            }
        }
    }
}
