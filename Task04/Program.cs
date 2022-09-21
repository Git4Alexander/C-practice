// Задача 4: Напишите программу, которая принимает 
// на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите целое число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число 3: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (max < num2) max = num2;
if (max < num3) max = num3;
Console.WriteLine($"max = {max}");
