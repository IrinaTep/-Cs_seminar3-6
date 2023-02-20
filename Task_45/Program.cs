/*
Напишите программу, которая будет создавать копию заданного массива 
с помощью поэлементного копирования.
*/

// Функция создания массива
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

// Функция вывода массива
string PrintArray (int[] arr)
{
    string array = ($"{arr[0]}");
    for (int i = 1; i < arr.Length; i++)
    {
        array = array + ($", {arr[i]}");
    }
    return array;
}

int[] CopyArray(int[] arr)
{
    int[] copyArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copyArray[i] = arr[i];
    }
    return copyArray;
}

int[] array = CreateArrayRndInt(6, 1, 9);
int[] copy = CopyArray(array);
copy[0] = 15;
Console.WriteLine($"{PrintArray(array)} -> {PrintArray(copy)}");
