/*
Напишите программу, которая принимает на
вход пятизначное число и проверяет, является ли оно
палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/
/*
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 10000 && number > 99999)
{
    Console.WriteLine("Некорректный ввод");
    return;
}
int firstDigit = number / 10000;
int fifthDigit = number % 10;
int secondDigit = ((number - firstDigit * 10000) / 1000);
int fourthDigit = ((number % 100) - fifthDigit) / 10;
// Console.WriteLine($"{firstDigit}, {secondDigit}, {fourthDigit}, {fifthDigit}");
if (firstDigit == fifthDigit && secondDigit == fourthDigit)
Console.WriteLine($"{number} является палиндромом");
else Console.WriteLine($"{number} не является палиндромом");
*/

void CheckPalindrome(int num)
{
    int firstDigit = num / 10000;
    int fifthDigit = num % 10;
    int secondDigit = ((num - firstDigit * 10000) / 1000);
    int fourthDigit = ((num % 100) - fifthDigit) / 10;
    if (firstDigit == fifthDigit && secondDigit == fourthDigit) Console.WriteLine($"{num} является палиндромом");
    else Console.WriteLine($"{num} не является палиндромом");
}

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 10000 || number > 99999)
{
    Console.WriteLine("Некорректный ввод");
    return;
}
CheckPalindrome(number);

