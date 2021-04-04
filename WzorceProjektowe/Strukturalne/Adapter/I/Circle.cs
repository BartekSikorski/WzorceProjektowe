namespace WzorceProjektowe.Strukturalne.Adapter.I
{
    public class Circle : ICircle
    {
        public Circle(decimal radius)
        {
            Radius = radius;
        }

        public decimal Radius { get; }
    }
}