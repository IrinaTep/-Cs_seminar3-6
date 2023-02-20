/*
Напишите программу, которая принимает на
вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
*/

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1)
{
    Console.WriteLine("Некорректный ввод");
    return;
}
Table(number);

void Table(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count,5}   {(count * count * count),5}");
        count++;
    }
}