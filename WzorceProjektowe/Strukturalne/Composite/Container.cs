using System;
using System.Collections.Generic;

namespace WzorceProjektowe.Strukturalne.Composite
{
    public class Container : ProductBase, IContainer
    {
        private List<ProductBase> _content;

        public Container(string name, decimal price) : base(name, price)
        {
            _content = new List<ProductBase>();
        }

        public void Add(ProductBase product)
        {
            _content.Add(product);
        }

        public override decimal CalculateTotalPrice()
        {
            decimal total = 0;
            Console.WriteLine($"{Name} zawiera produkty w następującej cenie:");

            foreach (var item in _content)
            {
                total += item.CalculateTotalPrice();
            }

            return total;
        }

        public void Remove(ProductBase product)
        {
            _content.Remove(product);
        }
    }
}