using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21
{
    public class Sweet
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public double Weight { get; set; }

        public Sweet() // конструктор класса Sweet
        {
            Name = "no name";
            Weight = -1;
            Price = -1;
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
}
