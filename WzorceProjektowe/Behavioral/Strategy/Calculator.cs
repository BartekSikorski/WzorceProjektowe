namespace WzorceProjektowe.Behavioral.Strategy
{
    public class Calculator
    {
        public ICalcStrategy Strategy { private get; set; }

        public float? Calculate(float value1, float value2)
        {
            return Strategy?.Calc(value1, value2);
        }
    }
}