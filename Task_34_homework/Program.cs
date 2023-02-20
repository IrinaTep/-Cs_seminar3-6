﻿/*
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
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
        else Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}

// Подсчет четных чисел в массиве
int NumberOfEvenNumbers(int[] array)
{
    int number = 0;
    for (int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0) number++;
    
    return number;
}

int[] arr = CreateArrayRndInt(5, 100, 999);
PrintArray(arr);
Console.Write($"В массиве количество четных чисел: {NumberOfEvenNumbers(arr)}");