using System;

namespace WzorceProjektowe.Strukturalne.Composite
{
    public class Product : ProductBase
    {
        public Product(string name, decimal price) : base(name, price)
        {
        }

        public override decimal CalculateTotalPrice()
        {
            Console.WriteLine($"{Name} ma cenę {Price}");
            return Price;
        }
    }
}