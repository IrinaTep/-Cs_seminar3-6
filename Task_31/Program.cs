﻿/*
1. Задайте массив из 12 элементов, 
2. заполненный случайными числами из промежутка [-9, 9]. 
3. Найдите сумму отрицательных и положительных элементов массива.

Например, 
в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
сумма положительных чисел равна 29, 
сумма отрицательных равна -20.
*/

// Функция создания массива
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

// Функция вывода массива
void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        //array[i] = rnd.Next(min, max + 1);
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}

int GetSumNegativeElem (int[] array)
{
    int sum = default; // по умолчанию; все равно, что = 0
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0) sum += array[i]; // sum = sum + array[i]
    }
    return sum;
}

int GetSumPositiveElem (int[] array)
{
    int sum = default; // по умолчанию; все равно, что = 0
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sum += array[i]; // sum = sum + array[i]
    }
    return sum;
}

/*
int[] GetSumPositiveNegativeElem (int[] array)
{
    int sumNegative = 0;
    int sumPositive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sumPositive += array[i];   // if(array[i] != 0) ноль по заданию ни с чем не суммируется
        if(array[i] < 0) sumNegative += array[i];   // {
    }                                               // if (array[i] > 0) sumPositive += array[i];
    return new int[]{sumPositive, sumNegative};     // else sumNegative += array[i];
}                                                   // }
*/                                                  // return new int[]{sumPositive, sumNegative}; 

int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);

int sumNegativeElem = GetSumNegativeElem(arr);
int sumPositiveElem = GetSumPositiveElem(arr);
Console.WriteLine($"Сумма положительных элементов = {sumPositiveElem}");
Console.WriteLine($"Сумма отрицательных элементов = {sumNegativeElem}");

/*
int[] sumPositiveNegativeElem = GetSumPositiveNegativeElem(arr);
Console.WriteLine($"Сумма положительных элементов = {sumPositiveNegativeElem[0]}");
Console.WriteLine($"Сумма отрицательных элементов = {sumPositiveNegativeElem[1]}");
*/