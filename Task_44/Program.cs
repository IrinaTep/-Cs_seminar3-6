﻿/*
Не используя рекурсию, выведите первые N чисел Фибоначчи.
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 01123
Если N = 3 -> 011
Если N = 7 -> 0112358
*/

int[] Fibonacci(int num)
{
    int[] array = new int[num];
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

string PrintArray(int[] arr)
{
    string array = ($"{arr[0]}");
    for (int i = 1; i < arr.Length; i++)
    {
        array = array + ($", {arr[i]}");
    }
    return array;
}

Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    int[] fib = Fibonacci(number);
    Console.WriteLine($"Если N = {number} -> {PrintArray(fib)}");
}
else Console.WriteLine("Некорректный ввод");