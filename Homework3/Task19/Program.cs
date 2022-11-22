// Задача 19. Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// // V 1.0
// //принимаем на вход пятизначное число
// int number = 0;
// while (number < 10000 || number > 99999)
// {
//     Console.Write("Введите пятизначное число: ");
//     number = Convert.ToInt32(Console.ReadLine());
//     if (number < 10000 || number > 99999)
//     {
//         Console.WriteLine("Число не пятизначное");
//     }
// }

// //cравниваем первую и поледнюю цифру, вторую и четвертую в числе
// if (number / 10000 == number % 10)
// {
//     if (number / 1000 % 10 == number % 100 / 10)
//     {
//         Console.WriteLine($"Число {number} является палиндромом");
//     }
//     else { Console.WriteLine($"Число {number} не является палиндромом"); }
// }
// else { Console.WriteLine($"Число {number} не является палиндромом"); }

//***********************************************************************
// V 2.0
// int numPalindrom = SetNumber("Palindrom");

// bool isPalindrom = IsPalindromInt(numPalindrom);

// string str = isPalindrom ? "является палиндромом" : "не является палиндромом";
// System.Console.WriteLine($"число {numPalindrom} {str}");
    
// int SetNumber(string numberName)	
//     {                              			
//         System.Console.WriteLine($"Enter number {numberName}: ");
//         int num = Convert.ToInt32(Console.ReadLine());
//         return num;
//     }
//     bool IsPalindromInt(int num)
//     {
//         int temp = num;
//         int reverse = 0;
//         while (temp > 0)
//         {
//             reverse = (reverse * 10) + (temp % 10);
//             temp /= 10; 
//         }
//         return reverse == num;
//     }
// *******************************************************************
// V 3.0 Версия Габиля (препод)

//     bool IsPalindromString(string str)
//     {
//         int size = str.Length;
//         for (int i = 0; i <= size / 2: ++i)
//         {
//             if (str[i] != str[size - 1 - i])
//             {
//                 return false;
//             }
//         }    
//         return true;
//     }
    



//         {
//            System.Console.WriteLine("Введите пятизначное число");
//              int num = int.Parse(Console.ReadLine());
//              Console.WriteLine((num == 0) || (reverse(num, 0) == num));
//              Console.ReadKey(true);
//         }
// static int reverse(int num, int count)
    
//     {
//     while (num > 0) { count = count * 10 + num % 10; num /= 10; }
//     }
//     return count;
 
// bool Palindrom(string s)
// {
//     for (int i = 0; i < s.Length / 2; i++)
 
//         if (s[i] != s[s.Length - i - 1])
//             return false;
//     return true;
// }
//     static void Main()
// {
//     Console.WriteLine("Введите два числа");           
//     int num = int.Parse(Console.ReadLine());
//     Console.WriteLine((num == 0) || (reverse(num, 0) == num));
//     Console.ReadKey(true);
// }
 
// static int reverse(int num, int acc)
// {
//     while (num > 0) { acc = acc * 10 + num % 10; num /= 10; }
//     return acc;
// }
// Console.WriteLine("да");

// static void Main(string[] args)
// {
//     int numA = SetNumber("A");
//     bool Palindrom = PositiveNeganivString(numA.ToString());

//     PositiveNegativ(numA) = bool Palindrom();
   
//     string str = PositiveNegativ(numA) ? "Да" : "Нет";
//     System.Console.WriteLine($"число {numA} {str}");
    

//     int SetNumber(string str)	
//     {                              			
// 	    System.Console.WriteLine($"Enter {str} numbers");
// 	    int num = int.Parse(Console.ReadLine());
// 	    return num;
//     }

//     bool Palindrom(int numA)
//     {   int num=numA;
//         for (int i = 0; i < num.Length / 2; i++)
//             if (num[i]!= num[i](num.Length- i - 1))
//              return false;
//         else return true;
//     }    
// } 

// temp /= 10; //убираем последнее число
