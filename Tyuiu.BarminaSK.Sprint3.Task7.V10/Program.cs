using Tyuiu.BarminaSK.Sprint3.Task7.V10.Lib;

namespace Tyuiu.BarminaSK.Sprint3.Task7.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Бармина С.К. | ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление итоговых решений к спринту                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнила: Бармина София Константиновна | ПИНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Старт диапазона = {startValue}");
            Console.WriteLine($"Конец диапазона = {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+----------+-----------+");
            Console.WriteLine("|    X     |    f(x)   |");
            Console.WriteLine("+----------+-----------+");

            double[] result = ds.GetMassFunction(startValue, stopValue);

            for (int i = 0; i < result.Length; i++)
            {
                int x = startValue + i;
                Console.WriteLine("|{0,5:d}     |  {1,7:f2}  |", x, result[i]);
            }

            Console.WriteLine("+----------+-----------+");
            Console.ReadKey();
        }
    }
}
