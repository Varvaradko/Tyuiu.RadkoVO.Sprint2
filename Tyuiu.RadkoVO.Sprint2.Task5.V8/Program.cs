using Tyuiu.RadkoVO.Sprint2.Task5.V8.Lib;

namespace Tyuiu.RadkoVO.Sprint2.Task5.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            DataService ds = new DataService();
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* Спринт #2                                                                      *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                               *");
            Console.WriteLine("* Задание #5                                                                     *");
            Console.WriteLine("* Вариант #8                                                                     *");
            Console.WriteLine("* Выполнил: Радько Варвара Олеговна | СМАРТб-25-1                                *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                       *");
            Console.WriteLine("* Дата некоторого дня характеризуется двумя натуральными числами: m (порядковый  *");
            Console.WriteLine("* номер месяца) и n (число). По заданным n и m определить дату предыдущего дня   *");
            Console.WriteLine("* (принять, что n и m не характеризуют 1 января).                                *");
            Console.WriteLine("*                                                                                *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* Введите X:                                                                     *");
            x = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("* Введите Y:                                                                     *");
            y = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                     *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine(ds.FindDateOfPreviousDay(x, y));

            Console.ReadLine();
        }
    }
}