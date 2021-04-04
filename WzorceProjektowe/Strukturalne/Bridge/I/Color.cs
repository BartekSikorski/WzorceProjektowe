namespace WzorceProjektowe.Strukturalne.Bridge.I
{
    public abstract class Color
    {
        public Brightness Brightness { get; set; }
        public abstract string ColorVALUE { get; }

        public override string ToString()
        {
            return Brightness != null ? Brightness.BrightnesValue + ColorVALUE : ColorVALUE;
        }
    }
}