// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

// Функция создания массива вещественных чисел
double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double [size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 2, MidpointRounding.AwayFromZero); 
        
    }
    return array;
}

// Функция вывода массива
void PrintArrayDouble(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

// Поиск максимального и минимального элементов массива
double MaxMinDiffFinder(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
        if(array[i] < min) min = array[i];
    }
    Console.WriteLine($"Максимальный элемент массива: {max}");
    Console.WriteLine($"Минимальный элемент массива: {min}");
    return max - min;
}

double[] arr = CreateArrayRndDouble(10, 0, 100);
PrintArrayDouble(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {MaxMinDiffFinder(arr)}");