// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// V 1.0
// using static System.Console;

// //Метод рекурсивного вывода чисел от N до 1.

// string RecursiveNumbers(int n)
// {
//     if (n == 1)
//     {
//         return "1";
//     }
//     else
//     {
//         return n + ", " + RecursiveNumbers(n - 1);
//     }
// }

// //Решение.

// WriteLine(RecursiveNumbers(10));
//*********************************************
// V 2.0

System.Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
	
string RecursiveNumbers(int n)
{
    if (n == 1)
    {
        return "1";
    }
    else
    {
        return n + ", " + RecursiveNumbers(n - 1);
    }
}
Console.WriteLine(RecursiveNumbers(n));
