/*
Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9  -> (-0.5; -0.5)
*/

Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

if (k1 != k2)
{
    double x = Math.Round(XFinder(b1, k1, b2, k2), 2);
    double y = Math.Round(YFinder(b1, k1, x), 2);
    Console.WriteLine($"Прямые пересекаются в точке: ({x}; {y})");
}
else Console.WriteLine("Прямые не пересекаются в точке");




double XFinder(double b1c, double k1c, double b2c, double k2c)
{
    return ((b2c - b1c) / (k1c - k2c));
}

double YFinder(double b1c, double k1c, double xc)
{
    return (k1c * xc + b1c);
}
