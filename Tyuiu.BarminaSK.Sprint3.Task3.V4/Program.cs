using Tyuiu.BarminaSK.Sprint3.Task3.V4.Lib;

namespace Tyuiu.BarminaSK.Sprint3.Task3.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Бармина С.К. | ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема:  Оператор цикла do-while                                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнила: Бармина София Константиновна | ПИНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, используя цикл do-while, которая вычисляет произве- *");
            Console.WriteLine("* дение ряда по формуле, при x = 1.                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "plkjidw cylkl";
            char item = 'j';

            Console.WriteLine($"Исходная строка: {value}");
            Console.WriteLine($"Удаляемый символ: {item}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string result = ds.DeleteCharInString(value, item);
            Console.WriteLine($"Результат: {result}");

            Console.ReadKey();

        }
    }
}