﻿namespace WzorceProjektowe.Behavioral.Strategy
{
    public class MultiplyCalcStrategy : ICalcStrategy
    {
        public float Calc(float value1, float value2)
        {
            return value1 * value2;
        }
    }
}