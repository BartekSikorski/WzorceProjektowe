using System;

namespace WzorceProjektowe.Strukturalne.Composite
{
    public abstract class ProductBase : ICloneable
    {
        protected ProductBase(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; }

        public decimal Price { get; }

        public abstract decimal CalculateTotalPrice();

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}