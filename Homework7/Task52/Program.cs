// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// // V 1.0
// //Cоздание двумерного массива.

// int[,] createArray(int n, int m)
// {
//     int[,] array = new int[n, m];
//     return array;
// }

// // Заполнение массива

// int[,] fillArray(int[,] array, int min, int max)
// {
//     Random rand = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rand.Next(min, max);
//         }
//     return array;
// }

// //Печать массива

// void printArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++, Console.WriteLine(""))
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "\t");
//         }
// }

// //Cоздание одномерного массива.

// double[] createDoubleArray(int n)
// {
//     double[] array = new double[n];
//     return array;
// }

// double[] fillDoubleArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = 0;
//     }
//     return array;
// }


// //Печать одномерного массива. 

// void printDoubleArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}  ");
//     }
// }

// //Метод подсчета среднего арифметического строк двумерного массива и записи в массив вещественных чисел.

// double[] AverageArray(int[,] array)
// {
//     double[] avgArray = createDoubleArray(array.GetLength(1));
//     avgArray = fillDoubleArray(avgArray);

//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         for (int j = 0; j < array.GetLength(0); j++)
//         {
//             avgArray[i] = avgArray[i] + array[j, i];
//         }
//         avgArray[i] = avgArray[i] / array.GetLength(0);
//     }
//     return avgArray;
// }

// //Решение. 

// int[,] array = createArray(5, 7);
// array = fillArray(array, 0, 10);
// printArray(array);
// Console.WriteLine("");
// double[] avgArray = AverageArray(array);
// Console.Write("Среднее арифметическое каждого столбца: ");
// printDoubleArray(avgArray);

//*******************************************************************
// V 2.0
int[,] CreateArray(int m, int n)
{
      int[,] array = new int[m, n];
	return array;
}
int[,] FillArray(int[,] array, int min, int max)
{
	Random random = new Random();
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i,j] = random.Next(min, max);
		}
	}
	return array;
}
void PrintArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i, j] + "\t");
		}
		Console.WriteLine(" ");
	}
}

double[] CreateNewArray(int n)
{
	double[] array = new double[n];
	return array;
}	
double[] FillNewArray(double[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = 0;
	}
	return array; 
}

double[] AverageArray(int[,] array)
{
	double[] avgArray = CreateNewArray(array.GetLength(1));
	avgArray = FillNewArray(avgArray);
	for (int i = 0; i < array.GetLength(1); i++)
	{
		for (int j = 0; j < array.GetLength(0); j++)
		{
			avgArray[i] = avgArray[i] + array[j, i];
		}
		avgArray[i] = avgArray[i] / array.GetLength(0);
	}
	return avgArray;
}
void PrintNewArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    	{
      Console.Write($"{array[i]}" + "\t");
      }
}
int[,] array = CreateArray(5,5);
array = FillArray(array, 10, 100);
PrintArray(array);
Console.WriteLine();
double[] avgArray = AverageArray(array);
Console.WriteLine($"Среднее арифметическое стобцов: ");  
PrintNewArray(avgArray);
