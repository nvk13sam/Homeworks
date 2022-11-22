// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// V 1.0
// int day = 6;
// if (day <= 7)
// {
//     if (day == 6 || day == 7)
//     {
//         Console.WriteLine(day + " - да");
//     }
//     else
//     {
//         Console.WriteLine(day + " - нет");
//     }
// }
// else
// {
//     Console.WriteLine("не является днем недели");
// }

//***************************************************
// V 2.0
Console.WriteLine("Введите число от 1 до 7");
int num=Convert.ToInt32(Console.ReadLine());
if(num >= 1 && num <= 5)
	{
      	Console.WriteLine("Рабочий день");                
	}
else 
if(num >=6 && num <=7)
	{
      	Console.WriteLine("Выходной день");                
	}
else
	{
    		Console.WriteLine("Не является днем недели");
	}
