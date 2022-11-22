// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
//         Console.Write($"{array[i]} ");
//     }
// }

// //Подсчет суммы элентов массива с нечетными индексами.

// int sumOddIndexDigits(int[] array)

// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 != 0)
//         {
//             sum = sum + array[i];
//         }
//     }
//     return sum;
// }

// //Решение.

// Console.Write("Введите количество элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] array = creadeArray(n);
// array = fillArray(array, -100, 100);
// printArray(array);
// System.Console.WriteLine();
// Console.WriteLine($"Cуммa элементов, стоящих на нечётных позициях -> {sumOddIndexDigits(array)}");

//***********************************************************************************
// V 2.0
int size = 6;

int[] arr = GetRandomArray(size, 0, 100);

PrintArray(arr);

int sum = GetSumOddPosition(arr);
System.Console.WriteLine();
System.Console.WriteLine ($"в этом массиве суммa элементов, стоящих на нечётных позициях = {sum}");

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

int GetSumOddPosition(int[] arr)
{     int sum = 0;
      for (int i = 0; i < arr.Length; i++)
      {
            if (i % 2 == 1)
	      sum = sum+arr[i];
      }
      return sum;
}