using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BarminaSK.Sprint3.Task7.V10.Lib
{
    public class DataService : ISprint3Task7V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] valueArray = new double[length];

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Sin(x) + 3;

                // Проверка деления на ноль
                if (denominator == 0)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    double fraction = (5 * x + 2.5) / denominator;
                    double f = fraction + 2 * x + Math.Cos(x);
                    valueArray[count] = Math.Round(f, 2);
                }
                count++;
            }

            return valueArray;
        }
    }
}
