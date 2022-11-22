// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// V 1.0
// using static System.Console;

// //Метод вычисление функции Аккермана.

// int Accerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0 & m > 0)
//     {
//         return Accerman(m - 1, 1);
//     }
//     else
//     {
//         return Accerman(m - 1, Accerman(m, n - 1));
//     }
// }

// //Решение.

// WriteLine(Accerman(3, 2));

//*************************************************************
// V 2.0
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

PrintAссermanFunction(m, n);

void PrintAссermanFunction(int m, int n)
{
    Console.Write(Accerman(m, n)); 
}

int Accerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 & m > 0)
    {
        return Accerman(m - 1, 1);
    }
    else
    {
        return Accerman(m - 1, Accerman(m, n - 1));
    }
}
