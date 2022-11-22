// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// // V 1.0

// using static System.Console;

// //Метод рекурсивного подсчета суммы чисел от M до N.

// int RecursiveSum(int m, int n)
// {
//     if (m == n)
//     {
//         return m;
//     }
//     else
//     {
//         return n + RecursiveSum(m, n - 1);
//     }
// }

// //Решение.

// WriteLine(RecursiveSum(1, 15));

//********************************************
// V 2.0
using static System.Console;

System.Console.WriteLine("Введите два числа");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

int RecursiveSum(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    else if (m < n)
    {
        return n + RecursiveSum(m, n - 1);
    }
    else
    {
        return m + RecursiveSum(n, m - 1);       
    }
}

Console.WriteLine($"Сумма чисел от {m} до {n} равна {RecursiveSum(m, n)}");