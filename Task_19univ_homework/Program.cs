/*
Напишите программу, которая принимает на
вход число любой длины и проверяет, является ли оно
палиндромом.
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int reverse = MakeReverse(number);
Console.WriteLine($"Reverse: {reverse}");

if (number - reverse == 0) 
    Console.WriteLine($"Число {number} палиндром");
else
    Console.WriteLine($"Число {number} не является палиндромом");


int MakeReverse(int num)
{
    int numReverse = 0;
    int numModulo = 0;

    while (num >= 1)
    {
        numModulo = num%10;
        num = num/10;
        numReverse = numReverse * 10 + numModulo;
    }

    return numReverse;
}
