using System;

namespace WzorceProjektowe.Strukturalne.Adapter.I
{
    public class Client
    {
        private const int ProperRadius = 5;

        public static void Execute()
        {
            var circle = new Circle(4);
            var square = new Square(8);

            Console.WriteLine(CheckRadius(circle));
            Console.WriteLine(CheckRadius(new CircleAdapter(square)));
        }

        public static bool CheckRadius(ICircle circle)
        {
            return circle.Radius <= ProperRadius;
        }
    }
}