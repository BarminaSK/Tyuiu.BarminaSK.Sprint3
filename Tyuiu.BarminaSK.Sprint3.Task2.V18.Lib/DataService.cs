using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BarminaSK.Sprint3.Task2.V18.Lib
{
    public class DataService : ISprint3Task2V18
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multiplySeries = 1.0;
            int k = startValue;

            do
            {
                double term = Math.Cos(value) + Math.Pow(k / 8.0, 3);
                multiplySeries *= term;
                k++;
            }
            while (k <= stopValue);

            return Math.Round(multiplySeries, 3);
        }
    }
}
