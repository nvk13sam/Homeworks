// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5   7   -2   -0,2
// 1   -3,3   8   -9,9
// 8    7,8  -7,1  9

// // V 1.0
// //Cоздание двумерного массива.

// double[,] createArray(int m, int n)
// {
//     double[,] array = new double[m, n];
//     return array;
// }

// // Заполнение массива

// double[,] fillArray(double[,] array, double min, double max)
// {
//     Random rand = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             var next = rand.NextDouble();
//             array[i, j] = min + next * (max - min);
//         }
//     return array;
// }
// //Печать массива

// void printArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++, Console.WriteLine(""))
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(Math.Round(array[i, j], 1) + "\t");
//         }
// }

// //Метод получение числа с консоли.

// int ReadNumber(string str)
// {
//     Console.WriteLine(str);
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }

// //Решение.
// int m = ReadNumber("Введите количество строк");
// int n = ReadNumber("Введите количество столбцов");
// double[,] array = createArray(m, n);
// array = fillArray(array, -10, 10);
// printArray(array);

//*********************************************************
// V 2.0
// Получение размера массива
int NumEnter(string str)
{
	Console.WriteLine(str);
	int number = int.Parse(Console.ReadLine());
	return number;
}
// Содание двумерного массива 
double[,] CreateArray(int m, int n)
{
      double[,] array = new double[m, n];
	return array;
}
// Заполнение массива
double[,] FillArray(double[,] array, int min, int max)
{
	Random random = new Random();
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			var next = random.NextDouble();
			array[i,j] = min + next * (max - min);
		}
	}
	return array;
}
// Печать массива
void PrintArray(double[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(Math.Round(array[i, j], 2) + "\t");
		}
		Console.WriteLine(" ");
	}
}
// 
int m = NumEnter("Введите количество строк: ");
int n = NumEnter("Введите количество столбцов: ");
double[,] array = CreateArray(m,n);
array = FillArray(array, -10, 10);
PrintArray(array);
