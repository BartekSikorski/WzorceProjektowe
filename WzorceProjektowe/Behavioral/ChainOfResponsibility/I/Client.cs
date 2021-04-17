using System;
using WzorceProjektowe.Behavioral.ChainOfResponsibility.I;

namespace WzorceProjektowe.Behavioral.ChainOfResponsibility
{
    public class Client
    {
        public static void Execute()
        {
            var handler3 = new DiscountHandler("3", 200, 6000);
            var handler2 = new DiscountHandler("2", 100, 8000, handler3);
            var handler1 = new DiscountHandler("1", 100, 10000, handler2);

            Console.WriteLine(handler1.Discount(250, 8000));
            Console.WriteLine(handler1.Discount(1000, 16000));
            Console.WriteLine(handler3.Discount(300, 10000));
        }
    }
}