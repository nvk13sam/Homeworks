// Задача 6.
//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

// V 1.0
// int number1 = 8;
// if (number1 % 2 == 0)
// {
//     Console.WriteLine(number1+" - четное");
// }
// else
// {
//     Console.WriteLine(number1+" - нечетное");
// }
//**************************************************
// V 2.0
System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
if (num%2 == 0){
               Console.WriteLine($"Число является четным");  
}
else
{
               Console.WriteLine($"Число является нечетным");  
}