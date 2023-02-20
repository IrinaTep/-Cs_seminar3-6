/*
Напишите программу, которая задаёт
массив из 8 элементов, заполненный
псевдослучайными числами и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] GenerateArray(int size)
{
    int[] arr = new int[size]; // 0, 1, 2, 3, 4, 5, 6, 7
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next();
    }
    return arr;
}

/*
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] array = GenerateArray(8);
PrintArray(array);
*/

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]} ");
    }
}
    
int[] array = GenerateArray(8);
PrintArray(array);
System.Console.Write(" -> [");
PrintArray(array);
System.Console.Write("]");