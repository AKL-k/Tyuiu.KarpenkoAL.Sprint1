using Tyuiu.KarpenkoAL.Sprint1.Task7.V25.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Карпенко А. Л. | ИБКСб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #25                                                             *");
Console.WriteLine("* Выполнил: Карпенко Артём Леонидович | ИБКСб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
Console.WriteLine("* исходным значениям данных, вводимых пользователем.                      *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("            y^2 + 6 + cos(x^3) + xy - 2x^2");
Console.WriteLine(" z = e^x - ------------------------------------");
Console.WriteLine("                  sin((x^4)+13) + 9y - 2");

double x, y;

Console.WriteLine("Введите значение X :");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение Y :");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.Calculate(x, y));

Console.ReadKey();
