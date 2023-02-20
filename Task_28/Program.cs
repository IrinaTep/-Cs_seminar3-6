/*
Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

/*
Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 0)
{
    int factorial = Factorial(number);
    Console.WriteLine($"Произведение чисел от 1 до {number} = {Factorial(number)}");
}
else System.Console.WriteLine("Введено некорректное значение");

int Factorial(int num)
{
    int factorial = 1;
    for (int i = 1; i <= num; i++)
    {
        factorial *= i;
    }
    return factorial;
}
*/

int Factorial(int number)
{
    int result = 1;
    int counter = 1;
    while (counter <= number)
    {
        result *= counter;
        counter++;
    }
    return result;
}
Console.Write("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 0) Console.WriteLine("Некорректный ввод");
else
{
    int factorial = Factorial(num);
    Console.WriteLine($"{num} -> {factorial}");
}
