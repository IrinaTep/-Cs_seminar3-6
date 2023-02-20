// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Функция создания массива
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max+1);
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

int SumElemOddIndex(int[] array)
{
    int sumElemOddIndex = 0;
    for(int i=0; i < array.Length; i++)
        if(i % 2 != 0) sumElemOddIndex += array[i];
    return sumElemOddIndex;

}

int[] arr = CreateArrayRndInt(12, -100, 100);
PrintArray(arr);
Console.WriteLine($"Сумма всех элементов, стоящих на нечетных позициях, равна: {SumElemOddIndex(arr)}");