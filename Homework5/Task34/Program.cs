// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// // V 1.0

// //Cоздание массива.

// int[] creadeArray(int n)
// {
//     int[] array = new int[n];
//     return array;
// }

// //Заполнение массива рандомными значениями.

// int[] fillArray(int[] array, int min, int max)
// {
//     Random rand = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rand.Next(min, max);
//     }
//     return array;
// }

// //Печать массива. 

// void printArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
// }

// //Метод подсчета четных чисел в массиве.

// int countEven(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// //Решение.

// Console.Write("Введите количество элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] array = creadeArray(n);
// array = fillArray(array, 100, 999);
// printArray(array);
// System.Console.WriteLine();
// Console.WriteLine($"Количество четных элементов -> {countEven(array)}");

//******************************************************************
// V 2.0

int size = 10;

int[] arr = GetRandomArray(size, 0, 100);
PrintArray(arr);
int Count = GetCount(arr);
System.Console.WriteLine();
System.Console.WriteLine ($"в этом массиве {Count} четных чисел");

int[] GetRandomArray(int size, int begin, int last)
{
    int[] arr = new int[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = random.Next(begin, last + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + ", ");
    }
}

int GetCount(int[] arr)
{
    int Count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)

            Count++;
    }

    return Count;
}
