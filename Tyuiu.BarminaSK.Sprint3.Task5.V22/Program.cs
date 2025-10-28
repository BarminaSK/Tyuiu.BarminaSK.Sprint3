using Tyuiu.BarminaSK.Sprint3.Task5.V22.Lib;

namespace Tyuiu.BarminaSK.Sprint3.Task5.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Бармина С.К. | ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема:  Вложенные циклы                                                  *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнила: Бармина София Константиновна | ПИНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 2;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 12;

            Console.WriteLine($"Переменная X = {x}");
            Console.WriteLine($"Старт шага внешнего цикла = {startValue1}");
            Console.WriteLine($"Конец шага внешнего цикла = {stopValue1}");
            Console.WriteLine($"Старт шага внутреннего цикла = {startValue2}");
            Console.WriteLine($"Конец шага внутреннего цикла = {stopValue2}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            Console.WriteLine($"Сумма ряда = {result}");

            Console.ReadKey();
        }
    }
}