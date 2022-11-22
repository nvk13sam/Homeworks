//Задача 4.
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// V 1.0
// int number1 = 22;
// int number2 = 3;
// int number3 = 9;
// int max = 0;
// if (number1 > number2)
// {
//     	max = number1;
// }
// else
// {
//     	max = number2;
// }
// if (max < number3)
// {
// 	max = number3;
// };
// Console.WriteLine("max = "+ max);

//*******************************************************
// V 2.0
System.Console.WriteLine("Введите три числа");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
int max = num1;
if (max < num2)
{
 	max = num2;
}            
if (max < num3)
{
 	max = num3;
}            
Console.WriteLine($"Число {max} максимальное из них");  