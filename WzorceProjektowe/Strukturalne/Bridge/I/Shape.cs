namespace WzorceProjektowe.Strukturalne.Bridge.I
{
    public abstract class Shape
    {
        public Color Color { get; set; }

        public override string ToString()
        {
            return $"{Color.ColorVALUE} {GetType().Name}";
        }
    }
}