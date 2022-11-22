Start();

void Start()
{
	while (true)
	{
		Console.ReadLine();
		Console.Clear();

		System.Console.WriteLine("54) Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
		System.Console.WriteLine("56) Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
		System.Console.WriteLine("58) Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
		System.Console.WriteLine("60) Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
		System.Console.WriteLine("62) Задача 62: Напишите программу, которая заполнит спирально массив 4 на 4. ");
		System.Console.WriteLine("0 End");

		int numTask = SetNumber("task");
		switch (numTask)
		{
			case 54: MySort(); break;
			case 56: MyMinSum(); break;
			case 58: MyTwoMatrix(); break;
			case 60: My3DArray(); break;
			case 62: MySpiral(); break;
			case 0: return; break;
			default: System.Console.WriteLine("error"); break;
		}
	}
}

void MySort()
{
	Console.WriteLine("Введите количество строк");
	int n = int.Parse(Console.ReadLine());

	Console.WriteLine("Введите количество столбцов");
	int m = int.Parse(Console.ReadLine());

	int[,] array = CreateArray(n, m);
	array = FillArray(array, 0, 100);
	PrintArray(array);
	array = GetSort(array);
	Console.WriteLine("Отсортированный массив");
	PrintArrayDouble(array);
}

void MyMinSum()
{
	int[,] array = CreateArray(4, 6);
	array = FillArray(array, 0, 10);
	PrintArray(array);
	Console.WriteLine("");
	Console.WriteLine($"Строка с наименьшей суммой элементов: {FindMinSumIndex(array)}");
}

void MyTwoMatrix()
{
	int[,] matrixA = CreateArray(2, 2);
	int[,] matrixB = CreateArray(2, 2);

	matrixA = FillArray(matrixA, 0, 10);
	matrixB = FillArray(matrixB, 0, 10);

	PrintArray(matrixA);
	Console.WriteLine();

	PrintArray(matrixB);
	Console.WriteLine();

	Console.WriteLine("Произведение двух матриц: ");
	int[,] matrixC = MatrixMultiplication(matrixA, matrixB);
	PrintArray(matrixC);
}

void My3DArray()
{
      int[,,] array = Create3DArray(2, 2, 2);
      array = Fill3DArray(array, 10, 99);      
	Print3DArray(array);
}

void MySpiral()
{
	int[,] array = FillSpiral(4);
	PrintArrayDouble(array);
}

int[,] CreateArray(int n, int m)
{
    	int[,] array = new int[n, m];
    	return array;
}

int[,] FillArray(int[,] array, int min, int max)
{
    	Random rand = new Random();
    	for (int i = 0; i < array.GetLength(0); i++)
        	for (int j = 0; j < array.GetLength(1); j++)
        	{
            	array[i, j] = rand.Next(min, max);
        	}
    	return array;
}

void PrintArray(int[,] array)
{
    	for (int i = 0; i < array.GetLength(0); i++, Console.WriteLine(""))
        	for (int j = 0; j < array.GetLength(1); j++)
        	{
            	Console.Write(array[i, j] + "\t");
        	}
}

void PrintArrayDouble(int[,] array)
{
    	for (int i = 0; i < array.GetLength(0); i++, Console.WriteLine(""))
        	for (int j = 0; j < array.GetLength(1); j++)
        	{
			if (array[i, j] < 10)
			Console.Write($"{"0"+array[i, j]} \t");
			else Console.Write(array[i, j] + "\t");
        	}
}


static int[,] GetSort(int[,] array)
{
    	int temp;
    	for (int i = 0; i < array.GetLength(0); i++)
    	{
        	for (int j = 0; j < array.GetLength(1); j++)
        	{
            	for (int k = j + 1; k < array.GetLength(1); k++)
            	{
                		if (array[i, j] < array[i, k])
                		{
                    		temp = array[i, j];
                    		array[i, j] = array[i, k];
                    		array[i, k] = temp;
                		}
            	}
        	}
    	}
    	return array;
}

int FindMinSumIndex(int[,] array)
{
    	int index = 1;
    	int min = 0;
    	for (int j = 0; j < array.GetLength(1); j++)
    	{
        	min = min + array[0, j];
    	}
    	int sum = 0;
    	for (int i = 0; i < array.GetLength(0); i++)
    	{
        	for (int j = 0; j < array.GetLength(1); j++)
        	{
            	sum = sum + array[i, j];
        	}

        	if (sum < min)
        	{
            	min = sum;
            	index = i + 1;
        	}
        	sum = 0;
    	}
    	return index;
}

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    	var matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    	for (var i = 0; i < matrixA.GetLength(0); i++)
    	{
        	for (var j = 0; j < matrixB.GetLength(1); j++)
        	{
            	matrixC[i, j] = 0;

            	for (var k = 0; k < matrixA.GetLength(1); k++)
            	{
                		matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            	}
        	}
   	}

    return matrixC;
} 

int[,,] Create3DArray(int n, int m, int l)
{
    	int[,,] array = new int[n, m, l];
    	return array;           
}

int[,,] Fill3DArray(int[,,] array, int min, int max)
{
    	Random rand = new Random();
    	for (int i = 0; i < array.GetLength(0); i++)
        	for (int j = 0; j < array.GetLength(1); j++)
               	for (int k = 0; k < array.GetLength(2); k++)
               	{
                        array[i, j, k] = rand.Next(min, max);
                	}
    	return array;
}

void Print3DArray(int[,,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
		for (int j = 0; j < array.GetLength(1); j++)
		{	for (int k = 0; k < array.GetLength(2); k++)
			{
				Console.Write($"{array[i, j, k]} ({i},{j},{k}) \t");
			}
		Console.WriteLine("");	
		}
}

int[,] FillSpiral(int n)
{
	int[,] array = new int[n, n];
	int count = n;
	int value = -n;
	int summa = -1;
	int position = 0;

	while (count > 0)
	{
		value = -1 * value / n;
		for (int i = 0; i < count; i++)
		{
			summa = summa + value;
			array[summa / n, summa % n] = position++;
		}
		value = value * n;
		count--;
		for (int i = 0; i < count; i++)
		{
			summa = summa + value;
			array[summa / n, summa % n] = position++;
		}
	}
	return array;
}

int SetNumber(string numberName)	
{                              			
	Console.WriteLine($"Enter {numberName} number");
	int num  = int.Parse(Console.ReadLine());
	return num;
}