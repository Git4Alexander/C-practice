// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек
// и находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки 1");
Console.Write("X1: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int ay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки 2");
Console.Write("X2: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int by = Convert.ToInt32(Console.ReadLine());

double Distance(int a1, int a2, int b1, int b2)
{
    double result = Math.Sqrt(Math.Pow((b1 - a1), 2) + Math.Pow((b2 - a2), 2));
    result = Math.Round(result, 2, MidpointRounding.ToZero);
    return result;
}

double res = Distance(ax, ay, bx, by);
Console.WriteLine($"Расстояние между точками равно {res}");