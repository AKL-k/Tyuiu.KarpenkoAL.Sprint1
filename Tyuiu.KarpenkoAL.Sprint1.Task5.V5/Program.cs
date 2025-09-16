using Tyuiu.KarpenkoAL.Sprint1.Task5.V5.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Карпенко А. Л. | ИБКСб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #5                                                              *");
Console.WriteLine("* Выполнил: Карпенко Артём Леонидович | ИБКСб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая решает следующую задачу: Присвоить целой    *");
Console.WriteLine("* переменной d 1-ую цифру из дробной части положительного вещественного x *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Double x;

Console.WriteLine("Введите Х");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
Console.WriteLine("***************************************************************************");

int d = Convert.ToInt32(ds.Calculate(x));
Console.WriteLine(" d = " + ds.Calculate(x));

Console.ReadKey();

