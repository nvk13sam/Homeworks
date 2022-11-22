// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// // V 1.0
// int sumDigits(int number)
// {
//     int sum = 0;
//     while (number / 10 != 0)
//     {
//         sum = sum + number % 10;
//         number = number / 10;
//     }
//     return sum + number;
// }

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(sumDigits(number));

//*******************************************************
// V 2.0
int num = SetNumber("N");
//FindSum(num);
Console.WriteLine($"Сумма цифр в числе равна {FindSum(num)}");
int SetNumber(string str)	
{                              			
	System.Console.WriteLine($"Enter {str} number");
	int num  = int.Parse(Console.ReadLine());
	return num;
}
int FindSum(int num)
{
      int sum = 0;
	while (num > 0)
	{
		sum = sum + num % 10;  
		num = num / 10;

	}      
	return sum;
}	