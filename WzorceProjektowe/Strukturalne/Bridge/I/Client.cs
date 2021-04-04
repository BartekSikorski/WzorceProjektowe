using System;

namespace WzorceProjektowe.Strukturalne.Bridge.I
{
    public class Client
    {
        public static void Execute()
        {
            var shape = new Circle();
            var color = new RedColor();

            shape.Color = color;

            Console.WriteLine(shape);
        }
    }
}