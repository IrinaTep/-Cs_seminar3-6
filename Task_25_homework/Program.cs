/*
Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Write("Введите основание степени: ");
double baseDegree = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите показатель степени: ");
int exponent = Convert.ToInt32(Console.ReadLine());
if (exponent > 0)
{
    double result = Exponention(baseDegree, exponent);
    Console.WriteLine($"Число {baseDegree}, возведенное в {exponent} степень = {result}");
}
else Console.WriteLine("Некорректный ввод, показатель степени должен быть натуральным числом");

double Exponention (double baseOfDegree, int exponentOfDegree)
{
    int count = 1;
    double result = 1;
    while (count <= exponentOfDegree)
    {
        result = result * baseOfDegree;
        count++;
    }
    return result;
}