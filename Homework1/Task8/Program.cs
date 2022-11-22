// Задача 8.
//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

// V 1.0
// int N = 8;
// int i = 1;
// while (i <= N)
// {
//     if (i % 2 == 0)
//     {
//         Console.Write(i+" ");
//     }
//     i++;
// }

//*********************************************
// V 2.0
System.Console.WriteLine("Введите числo");
int num = int.Parse(Console.ReadLine());
System.Console.WriteLine($"Четные числа от 1 до {num}: ");
while (num > 2)
{
               if (num%2 == 0)
               {
                              Console.Write (num + ", ");  
               }
               num=num-1;
}
if (num == 2)
{
               Console.WriteLine(num);
}
