﻿/*
Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

// Функция создания массива
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}


// Функция вывода массива
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        //array[i] = rnd.Next(min, max + 1);
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

// Нахождение произведения пар чисел, вывод нового массива

int[] ArrayProductNumberFirstLast(int[] array)
{
    int size = array.Length / 2;
    if(array.Length % 2 == 1) size += 1;
    int[] arrayNew = new int[size];
    for (int i = 0; i < size; i++)
    {
        arrayNew[i] = array[i] * array[array.Length - 1 -i];
    }
    if (array.Length % 2 == 1) arrayNew[arrayNew.Length - 1] = array[array.Length / 2];
    return arrayNew;
}
int[] arr = CreateArrayRndInt(5, 0, 100);
PrintArray(arr);
int [] arrNew = ArrayProductNumberFirstLast(arr);
PrintArray(arrNew);