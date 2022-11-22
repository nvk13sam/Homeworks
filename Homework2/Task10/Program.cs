// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// V 1.0
// int number = 169;
// int n = 0;
// n = number / 10;
// n = n % 10;
// Console.WriteLine("Second digit of number "+number+" is "+n);

//********************************************************
// V 2.0
System.Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
if(num>99 && num<1000){

      int numSecond = num/10;
      numSecond = numSecond % 10;
      Console.WriteLine($"Вторая цифра первого числа {numSecond}");

}
else{
      Console.WriteLine("Число не трехзначное");
}