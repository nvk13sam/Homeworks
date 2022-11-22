// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// V 1.0
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// for (int i = 1 ; i <= number ; i++)
// {
//     Console.Write( i*i*i +", ");
// }

//*********************************************************
// V 2.0
int num = SetNumber("N");

int[] arr = Cube(num);

System.Console.WriteLine(String.Join(", ", arr));

int SetNumber(string str)
{
    System.Console.WriteLine($"Enter {str} number");
    int num = int.Parse(Console.ReadLine());
    return num;
}
int[] Cube(int num)
{   
    int[] arr = new int[num];
    for (int i = 1; i <= num; i++)
    {
        arr[i - 1] = i * i * i;
    }
    return arr;
}
