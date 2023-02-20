/*
Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввел пользователь.
0, 7, 8, -2, -2  -> 2
-1, -7, 567, 89, 223  -> 3
*/

int[] UserInputArray(int arrSize)
{
    int[] array = new int[arrSize];
    for (int i = 0; i < arrSize; i++)
    {
        Console.Write("Введите элемент: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int PositiveNumbersCounter(int[] array)
{
    int positiveNumbersCounter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) positiveNumbersCounter += 1;
    }
    return positiveNumbersCounter;
}

Console.Write("Введите количество элементов для проверки: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = UserInputArray(size);
PrintArray(arr);
Console.WriteLine($"Положительных чисел в массиве: {PositiveNumbersCounter(arr)}");