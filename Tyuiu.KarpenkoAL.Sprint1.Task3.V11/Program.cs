using Tyuiu.KarpenkoAL.Sprint1.Task3.V11.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Карпенко А. Л. | ИБКСб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #11                                                             *");
Console.WriteLine("* Выполнил: Карпенко Артём Леонидович | ИБКСб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int x1;

Console.WriteLine("Введите X1:");
x1 = Convert.ToInt32(Console.ReadLine());

int y1;

Console.WriteLine("Введите Y1:");
y1 = Convert.ToInt32(Console.ReadLine());

int x2;

Console.WriteLine("Введите X2:");
x2 = Convert.ToInt32(Console.ReadLine());

int y2;

Console.WriteLine("Введите Y2:");
y2 = Convert.ToInt32(Console.ReadLine());

int x3;

Console.WriteLine("Введите X3:");
x3 = Convert.ToInt32(Console.ReadLine());

int y3;

Console.WriteLine("Введите Y3:");
y3 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Площадь треугольника (кв.см)= " + ds.TriangleArea(x1, y1, x2, y2, x3, y3));

Console.ReadKey();