// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки 1");
Console.Write("X1: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
int az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки 2");
Console.Write("X2: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
int bz = Convert.ToInt32(Console.ReadLine());

double Distance(int a1, int a2, int a3, int b1, int b2, int b3)
{
    double result = Math.Sqrt(Math.Pow((b1 - a1), 2) + Math.Pow((b2 - a2), 2) + Math.Pow((b3 - a3), 2));
    result = Math.Round(result, 2, MidpointRounding.ToZero);
    return result;
}

double res = Distance(ax, ay, az, bx, by, bz);
Console.WriteLine($"Расстояние между точками равно {res}");