using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BarminaSK.Sprint3.Task4.V21.Lib
{
    public class DataService : ISprint3Task4V21
    {
        public double Calculate(int startValue, int stopValue)
        {
            double multiplySeries = 1.0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    continue;
                }

                double y = (Math.Cos(x) - x) / x;
                multiplySeries *= y;
            }

            return Math.Round(multiplySeries, 3);
        }
    }
}
