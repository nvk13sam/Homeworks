﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// // V 1.0
// // Считаем координату x точки пересечения.

// double calculateX(double b1, double k1, double b2, double k2)
// {
//     return (b2 - b1) / (k1 - k2);
// }

// // Считаем координату y точки пересечения.

// double calculateY(double b1, double k1, double x)
// {
//     return k1 * x + b1;
// }

// // Решение.

// Console.Write("Введите коэффициент b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите коэффициент k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите коэффициент b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите коэффициент k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());

// double x = calculateX(b1, k1, b2, k2);
// double y = calculateY(b1, k1, x);
// Console.WriteLine($"({x};{y})");

//***********************************************
// V 2.0
Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
 
var x = (b2 - b1)/(k1 - k2);
var y = k1 * x + b1;
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");
