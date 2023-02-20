/*
Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
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
    Console.Write("]");
}

// Нахождение количества элементов, значения которых лежат в отрезке [10,99]
/*
int FindAmountOfElem (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 9 && arr[i] < 100)
        {
            count ++;
        }
    }
     return(count);
}

// Создание массива, вызов функции, dsdjl htpekmnfnf
int[] array = CreateArrayRndInt(123, 0, 200);
PrintArray(array);
Console.Write($"-> {FindAmountOfElem (array)} ");
*/

int ReturnNumberElements(int[] array, int min, int max)
{
    int numberElem = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min && array[i] <= max)
        {
            numberElem += 1;
        }
    }
    return numberElem;
}
int[] arr = CreateArrayRndInt(5, 0, 100);
PrintArray(arr);

int returnNumberElements = ReturnNumberElements(arr, 10, 99);
Console.Write($" -> {returnNumberElements}");
