/*
Напишите программу, которая принимает на вход три числа
и проверяет, может ли существовать треугольник с сторонами такой длины.
(Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.)
*/

Console.Write("Введите первую сторону треугольника: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую сторону треугольника: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью сторону треугольника: ");
int number3 = Convert.ToInt32(Console.ReadLine());

/*
bool TriangleCheck(int num1, int num2, int num3)
{
    if (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2)  //return num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2;
    {
        return true;
    }
    return false;
}

bool result = TriangleCheck(number1, number2, number3);
Console.WriteLine(result);        
*/

bool TriangleCheck(int num1, int num2, int num3)
{
    return num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2;
}

bool result = TriangleCheck(number1, number2, number3);
Console.WriteLine(result ? "Да" : "Нет");
