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

            Console.WriteLine("\n\n\t\tGiftList:");
            Console.WriteLine("\t\t-----------");


            for (int i = 0; i < countSweets; i++)
            {
                Sweet sweet = sweets[i];
                Console.Write("\n{0}:", i + 1);
                //Sweet.print(sweet);
                //Console.Write("{0}:\t{1}\t{2} byn\t{3}\t", i + 1, sweet.Name.PadRight(15), sweet.Price.ToString().PadRight(5), sweet.sweetKind.PadRight(10));
                if (sweet is Cookie cookie && !(sweet is CookieFortune cookief))
                {
                    cookie.print(cookie);

                    //Console.WriteLine(" {0}", cookie.IsChocolate ? "chocolate".PadRight(15) : "non-chocolate".PadRight(15));
                }
                else if (sweet is Candy candy)
                {
                    candy.print(candy);

                    //Console.WriteLine(" {0}", candy.IsSugarFree ? "sugar-free".PadRight(15) : "full of sugar".PadRight(15));
                }
                else if (sweet is Cheesecake cheesecake)
                {
                    cheesecake.print(cheesecake);
                    //Console.WriteLine(" {0}", cheesecake.IsBacked ? "was backed".PadRight(15) : "wasn't baked".PadRight(15));
                }
                else if (sweet is Cupcake cupcake)
                {
                    cupcake.print(cupcake);

                    //Console.WriteLine(" {0}", cupcake.IsFrosted ? "has frosting".PadRight(15) : "doesn't have frosting".PadRight(15));
                }
                else if (sweet is CookieFortune cookieF)
                {
                    cookieF.print(cookieF);

                    //Console.WriteLine(" {0}\t{1}", cookieF.IsChocolate ? "chocolate".PadRight(15) : "non-chocolate".PadRight(15), cookieF.HasAnswer ? "the answer is yes".PadRight(15) : "the answer is no".PadRight(15));
                }
            }

            Console.WriteLine("\n");
        }
    }
}
