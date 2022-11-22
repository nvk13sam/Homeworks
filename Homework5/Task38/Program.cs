// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// V 1.0
// //Cоздание массива.

// double[] creadeArray(int n)
// {
//     double[] array = new double[n];
//     return array;
// }

// //Заполнение массива рандомными значениями.

// double[] fillArray(double[] array, double min, double max)
// {
//     Random rand = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         var next = rand.NextDouble();
//         array[i] = min + next * (max - min);
//     }
//     return array;
// }

// //Печать массива. 

// void printArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]:f1} ");
//     }
// }

// //Нахождение максимального элемента в массиве.

// double maxValue(double[] array)
// {
//     double max = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > max)
//         {
//             max = array[i];
//         }
//     }
// return max;
// }

// //Нахождение минимального элемента в массиве.

// double minValue(double[] array)
// {
//     double min = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < min)
//         {
//             min = array[i];
//         }
//     }
// return min;
// }

// //Решение.

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// double[] array = creadeArray(n);
// array = fillArray(array, 0, 100);
// printArray(array);
// Console.WriteLine($"-> {maxValue(array) - minValue(array)} ");


//**********************************************************************
// V 2.0 
int size = 10;
int[] arr = GetRandomArray(size, 0, 100);
PrintArray(arr);
int difference = GetDifference(arr);
System.Console.WriteLine();

System.Console.WriteLine($"в этом массиве разница между минимальным и максимальным элементом = {difference}");

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

int GetDifference(int[] arr)
{
    	int max = 0;
    	int min = 100000;
    	for (int i = 0; i < arr.Length; i++)
    	{
        	if (arr[i] > max)
        	{
            	max = arr[i];
        	}
        
    	}    
     	for (int j = 0; j < arr.Length; j++)
    	{
        	if (arr[j] < min)
        	{
            	min = arr[j];
        	}
    	}       
    
    	difference = max - min;
    	return difference;
}
