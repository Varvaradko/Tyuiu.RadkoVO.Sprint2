using Tyuiu.RadkoVO.Sprint2.Task3.V25.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнил: Радько В. О.  | СМАРТб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #25                                                             *");
Console.WriteLine("* Выполнил: Радько Варвара Олеговна  | СМАРТБ-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу на, которая вычисляет требуемое значение фунции Y с  *");
Console.WriteLine("* использованием вложенных операторов if - else, где пользователь вводит  *");
Console.WriteLine("* значение переменной Х с клавиатуры.                                     *");                           
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите значение переменной Х: ");
double x = Convert.ToDouble(Console.ReadLine());

double res = ds.Calculate(x);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Значение функции = " + res);

Console.ReadKey();