// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.  
// 0, 7, 8, -2, -2 -> 2

// // V 1.0
// //Преобразуем строку в массив строк.

// string[] stringToArray(string s)
// {
//     string[] stringArray = s.Split(",");
//     return stringArray;
// }

// //Преобразуем массив сторок в массив целых чисел.

// int[] strToIntArray(string[] stringArray)
// {
//     int[] intArray = new int[stringArray.Length];
//     for (int i = 0; i < intArray.Length; i++)
//     {
//         intArray[i] = Convert.ToInt32(stringArray[i]);
//     }
//     return intArray;
// }

// //Считаем количество положительных чисел.

// int positiveCount(int[] intArray)
// {
//     int count = 0;
//     for (int i = 0; i < intArray.Length; i++)
//     {
//         if (intArray[i] > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// //Решение.

// Console.Write("Введите числа через запятую: ");
// string str = Console.ReadLine();
// string[] strArray = stringToArray(str);
// int[] intArray = strToIntArray(strArray);
// Console.WriteLine($"Положительных чисел в массиве " + positiveCount(intArray));


//************************************************
// V 2.0
Console.WriteLine("Введите числа через запятую: ");
string str = Console.ReadLine();

var ArrayString = str.Split(",");
int[] arr = Array.ConvertAll(ArrayString, int.Parse);
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
	if (arr[i] > 0) count++;
}
Console.WriteLine($"Положительных элементов в данном массиве {count}");

