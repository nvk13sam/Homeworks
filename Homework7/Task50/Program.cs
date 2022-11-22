// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

// //Метод получение числа с консоли.

// int ReadNumber(string str)
// {
//     Console.WriteLine(str);
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }

// //Метод, который сообщает, есть ли вводимые координаты в двумерном массиве.

// bool IsCoordinatesExist(int[,] array, int x, int y)
// {
//     if (x <= array.GetLength(0) & y <= array.GetLength(1))
//     {
//         return true;
//     }
//     else return false;
// }

// //Решение

// int[,] array = createArray(4, 3);
// array = fillArray(array, 0, 100);
// printArray(array);

// Console.WriteLine("");
// int x = ReadNumber("Введите координату x");
// int y = ReadNumber("Введите координату y");

// if (IsCoordinatesExist(array, x, y))
// {
//     Console.WriteLine(array[x - 1, y - 1]);
// }
// else
// {
//     Console.WriteLine($"{x},{y} - Такого элемента нет");
// }

//****************************************************************
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
int NumEnter(string str)
{
	Console.WriteLine(str);
	int number = int.Parse(Console.ReadLine());
	return number;
}
bool IsSuchCoordinate(int[,] array, int x, int y)
{
	if (x <= array.GetLength(0) && y <= array.GetLength(1))
	{
		return true;
	}
	else return false;
}
int[,] array = CreateArray(5,5);
array = FillArray(array, 0, 100);
PrintArray(array);


int x = NumEnter("Введите позицию строки элемента: ");
int y = NumEnter("Введите позицию столбца элемента: ");

if (IsSuchCoordinate (array, x, y))
{
	Console.WriteLine(array[x-1, y-1]);
}
else
{
	Console.WriteLine($"Элемента с координатами {x},{y} нет");
}
