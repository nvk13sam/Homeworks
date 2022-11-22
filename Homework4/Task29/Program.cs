// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// V 1.0
// int[] randomArray(int n)
// {
//     int[] array = new int[n];
//     Random rand = new Random();
//     for (int i = 0; i < n; i++)
//     {
//         array[i] = rand.Next(0, 100);
//         Console.Write(array[i] + ", ");
//     }
//     return array;
// }

// Console.Write("Введите количество элементов массива: ");
// int[] randArray = randomArray(Convert.ToInt32(Console.ReadLine()));

//*********************************************************************
// V 2.0
int size = SetNumber("size");
int begin = SetNumber("begin");
int last = SetNumber("last");

int [] arr = GetRandomArray(size, begin, last);

PrintArray(arr);
System.Console.WriteLine();
Console.WriteLine($"[{String.Join(", ", arr)}]");

int SetNumber(string str)	
{                              			
	System.Console.WriteLine($"Enter {str} number");
	int num  = int.Parse(Console.ReadLine());
	return num;
}

int[] GetRandomArray(int size, int begin, int last)
{
	int[] result = new int[size];
	Random random = new Random();

	for (int i = 0; i < size; i++)
	{
		result[i] = new Random().Next(begin, last);
	}
	return result;
}

void PrintArray(int[]arr)
{
	for (int i = 0; i < arr.Length; i++)
	{
		Console.Write(arr[i] + ", ");
		
	}
}
