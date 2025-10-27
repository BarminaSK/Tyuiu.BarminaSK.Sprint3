using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BarminaSK.Sprint3.Task1.V25.Lib
{
    public class DataService : ISprint3Task1V25
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multiplySeries = 1.0;
            int k = startValue;

            while (k <= stopValue)
            {
                double term = (Math.Pow(value, k) - 0.25) * Math.Cos(5);
                multiplySeries *= term;
                k++;
            }

            return Math.Round(multiplySeries, 3);
        }
    }
}
