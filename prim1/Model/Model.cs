using System;
using System.Collections.Generic;
using System.Linq;
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
    }

    public class Candy : Sweet
    {
        public bool IsSugarFree { get; set; }
    }

    public class Cookie : Sweet
    {
        public bool IsChocolate { get; set; }
    }
    public class CookieFortune : Cookie
    {
        public bool HasAnswer { get; set; }
    }
    public class Cheesecake : Sweet
    {
        public bool IsBacked { get; set; }
    }

    public class Cupcake : Sweet
    {
        public bool IsFrosted { get; set; }
    }
}
