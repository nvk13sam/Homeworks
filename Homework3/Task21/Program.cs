// Задача 21. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// V 1.0
// int[] readPoint()
// {
//     int[] point =   { 0, 0, 0 };
//     for (int i = 0; i <= 2; i++)
//     {
//         Console.Write("Введите координату: ");
//         point[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return point;
// }

// Console.WriteLine("Введите координаты точки А");
// int[] pointA = readPoint();
// Console.WriteLine("Введите координаты точки B");
// int[] pointB = readPoint();
// double length = 0;
// for (int i = 0; i <= 2; i++)
// {
//     length = length + (pointB[i] - pointA[i]) * (pointB[i] - pointA[i]);
// }
// Console.WriteLine(Math.Round(Math.Sqrt(length),2));

// V 2.0
class Program 
{
      static void Main(string[] args)
	{
		int X1 = SetNumber("X1");
		int Y1 = SetNumber("Y1");
		int Z1 = SetNumber("Z1");

		int X2 = SetNumber("X2");
		int Y2 = SetNumber("Y2");
		int Z2 = SetNumber("Z2");

		double result = DistanceDots(X1,X2,Y1,Y2,Z1,Z2);
		
		System.Console.WriteLine("Distantion = " + (Math.Round(result,2)));


 		int SetNumber(string str)	
			{                              			
			System.Console.WriteLine($"Enter {str} coordinate");
			int num  = int.Parse(Console.ReadLine());
			return num;
			}
		double DistanceDots (int X1, int X2,int Y1,int Y2,int Z1,int Z2)
			{
			result = Math.Sqrt(Math.Pow((X2 - X1),2) + Math.Pow((Y2-Y1),2) + Math.Pow((Z2-Z1),2));

			return result;
			}  
	}     
}
