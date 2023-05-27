using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lab21.Model
{
    public class Sweet
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public decimal Price { get; set; }
        public string sweetKind { get; set; }

        public Sweet()
        {
            Name = "no name";
            Weight = -1;
            Price = -1;
            sweetKind = string.Empty;
        }
        public Sweet(string _name, decimal _price, double _weight, string _sweetKind)
        {
            Name = _name;
            Price = _price;
            Weight = _weight;
            sweetKind = _sweetKind;
        }
        public Sweet(Sweet sweet)
        {
            Name = sweet.Name;
            Price = sweet.Price;
            Weight = sweet.Weight;
            sweetKind = sweet.sweetKind.ToString();
        }
        public void print(Sweet sweet) 
        {
            Console.Write("\t{0}\t{1} byn\t{2}\t", sweet.Name.PadRight(15), sweet.Price.ToString().PadRight(5), sweet.sweetKind.PadRight(10));
        }
    }

    public class Candy : Sweet
    {
        public bool IsSugarFree { get; set; }
        public void print(Candy candy)
        {
            base.print(candy);
            Console.Write(" {0}", candy.IsSugarFree ? "sugar-free".PadRight(15) : "full of sugar".PadRight(15));
        }
    }

    public class Cookie : Sweet
    {
        public bool IsChocolate { get; set; }
        public void print(Cookie cookie)
        {
            base.print(cookie);
            Console.Write(" {0}", cookie.IsChocolate ? "chocolate".PadRight(15) : "non-chocolate".PadRight(15));
        }
    }
    public class CookieFortune : Cookie
    {
        public bool HasAnswer { get; set; }
        public void print(CookieFortune cookieF)
        {
            base.print(cookieF);
            Console.Write(" {0}", cookieF.HasAnswer ? "the answer is yes".PadRight(15) : "the answer is no".PadRight(15));
        }
    }
    public class Cheesecake : Sweet
    {
        public bool IsBacked { get; set; }
        public void print(Cheesecake cheesecake)
        {
            base.print(cheesecake);
            Console.Write(" {0}", cheesecake.IsBacked ? "was backed".PadRight(15) : "wasn't baked".PadRight(15));
        }
    }

    public class Cupcake : Sweet
    {
        public bool IsFrosted { get; set; }
        public void print(Cupcake cupcake)
        {
            base.print(cupcake);
            Console.Write(" {0}", cupcake.IsFrosted ? "has frosting".PadRight(15) : "doesn't have frosting".PadRight(15));
        }
    }
}
