//Задача 2.
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// V 1.0
// int number1 = -9;
// int number2 = -3;
// if (number1>number2)
// {
//     Console.WriteLine("max = "+number1);
//     Console.WriteLine("min = "+number2);
// }
// else
// {
//     Console.WriteLine("max = "+number2);
//     Console.WriteLine("min = "+number1);
// }

//**********************************************
// V 2.0
System.Console.WriteLine("Введите два числа");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int max = num1;
int min = num2;
if (max < min)
{
      max = num2;
      min = num1;
      {
            System.Console.WriteLine($"Число {max} больше числа {min}"); 
      }
}               

if (max == min) 
{
      Console.WriteLine($"Число {max} равно числу {min}");        
}
