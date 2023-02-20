/* 
Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 0) number = number * (-1);

int sumDigits = SumAllDigits(number);
Console.WriteLine($"Сумма всех цифр в числе {number} = {sumDigits}");

int SumAllDigits(int num)
{
    int sumDig = 0;

    while (num >= 1)
    {
        sumDig = sumDig + num%10;
        num = num/10;
    }
    return sumDig;
}