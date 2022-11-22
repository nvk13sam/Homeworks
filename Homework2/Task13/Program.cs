// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// V 1.0
// int number = 32979;
// int n = number;
// if (n >= 100)
// {
//     while (n >= 1000)
//     {
//         n = n / 10;
//     }
//     n = n % 10;
//     Console.WriteLine("Третья цифра числа "+number+" - "+n);
// } else
// {
//     Console.WriteLine("Третьей цифры нет");
// }

//*************************************************************
// V 2.0
System.Console.WriteLine("Введите трехзначное число");
long num = Convert.ToInt64(Console.ReadLine());
if (num >= 100)
{
    while (num >= 1000)
    {
        num = num / 10;
    }
    long numThird = num % 10;
    Console.WriteLine($"Третья цифра заданного числа {numThird}");
}    
else{
      Console.WriteLine("Третьей цифры нет");
}
