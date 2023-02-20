/*
Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

/*
Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int BinaryNumber(int num)
{
    int res = 0;
    int count = 1;
    while (num > 0)
    {
        res += num % 2 * count;
        num /= 2;
        count *= 10;
    }
    return res;
}

int result = BinaryNumber(number);
Console.WriteLine(result);
*/

/* ВТОРОЙ ВАРИАНТ

void ToBin(int number)
{
    int counter = 1;
    while (counter < number) counter *= 2;
    counter /= 2;
    while (counter >= 1)
    {
        if (number - counter >= 0)
        {
            Console.Write($"{1}");
            number -= counter;
        }
        else if (number - counter < 0) Console.Write($"{0}");
        counter /= 2;
    }
}

Console.Write("Введите десятичное число: ");
int num = Convert.ToInt32(Console.ReadLine());
ToBin(num);
*/

/* ТРЕТИЙ ВАРИАНТ
*/
string DecToBin(int num)
{
    string result = string.Empty;
    while (num > 0)
    {
        result = num % 2 + result;
        num = num / 2;
    }
    return result;
}

Console.Write("Введите десятичное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

string decToBin = DecToBin(number1);

Console.Write(number1);
Console.Write(" -> ");
Console.Write(decToBin);