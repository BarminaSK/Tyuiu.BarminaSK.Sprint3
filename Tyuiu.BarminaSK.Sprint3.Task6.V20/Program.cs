using Tyuiu.BarminaSK.Sprint3.Task6.V20.Lib;

namespace Tyuiu.BarminaSK.Sprint3.Task6.V20
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

            int startValue = 20;
            int stopValue = 32;

            Console.WriteLine($"Старт диапазона = {startValue}");
            Console.WriteLine($"Конец диапазона = {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.GetSumTheDivisors(startValue, stopValue);
            Console.WriteLine($"Количество делителей меньше 12 = {result}");

            Console.ReadKey();
        }
    }
}