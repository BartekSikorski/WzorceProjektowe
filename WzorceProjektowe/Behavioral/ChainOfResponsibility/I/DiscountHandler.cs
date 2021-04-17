using System;

namespace WzorceProjektowe.Behavioral.ChainOfResponsibility.I
{
    public class DiscountHandler : BaseHandler<DiscountHandler>, IDiscountHandler

    {
        private readonly float _maxDiscount;
        private readonly float _minPrice;

        public string Name { get; }

        public DiscountHandler(string name, float maxDiscount, float minPrice, DiscountHandler nextHandler) : base(nextHandler)
        {
            _maxDiscount = maxDiscount;
            _minPrice = minPrice;
            Name = name;
        }

        public DiscountHandler(string name, float maxDiscount, float minPrice) : this(name, maxDiscount, minPrice, null)
        {
        }

        public bool Discount(float value, float price)
        {
            if (_maxDiscount >= value && price >= _minPrice)
            {
                Console.WriteLine($"Rabat {value} przyznany przez {Name}");
                return true;
            }
            return NextHandler?.Discount(value, price) ?? false;
        }
    }
}