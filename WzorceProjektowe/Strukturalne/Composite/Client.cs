using System;

namespace WzorceProjektowe.Strukturalne.Composite
{
    public class Client
    {
        public static void Execute()
        {
            var store = new Container("Magazyn", 0);
            var shelf1 = new Container("Półka 1", 0);
            var shelf2 = new Container("Półka 2", 0);
            var box1 = new Container("Pudło 1", 0);
            var box2 = new Container("Pudło 2", 0);
            var box3 = new Container("Pudło 3", 0);

            var coffee = new Product("Kawa", 12);
            var tea = new Product("Herbata", 10);
            var sugar = new Product("Cukier", 2);

            store.Add(shelf1);
            store.Add(shelf2);

            shelf1.Add(box1);
            shelf1.Add(box2);

            shelf2.Add(box3);

            for (int i = 0; i < 15; i++)
            {
                box1.Add((ProductBase)coffee.Clone());
            }

            for (int i = 0; i < 25; i++)
            {
                box2.Add((ProductBase)tea.Clone());
            }

            for (int i = 0; i < 20; i++)
            {
                box3.Add((ProductBase)sugar.Clone());
            }

            var price = store.CalculateTotalPrice();
            Console.WriteLine($"Cena sumaryczna: {price}");

            price = shelf1.CalculateTotalPrice();
            Console.WriteLine($"Cena sumaryczna: {price}");
        }
    }
}