﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BarminaSK.Sprint3.Task0.V20.Lib
{
    public class DataService : ISprint3Task0V20
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multiplySeries = 1.0;
            for (int k = startValue; k <= stopValue; k++)
            {
                double term = Math.Cos(value) + Math.Pow(k / 8.0, 3);
                multiplySeries *= term;
            }
            return Math.Round(multiplySeries, 3);
        }
    }
}
