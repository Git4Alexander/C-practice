
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = RaiseToADegree(number1, number2);
Console.WriteLine($"число {number1} в степени {number2} равно {result}");

int RaiseToADegree(int num1, int num2)
{
    int raiseToADegree = 1;
    for (int i = 1; i <= num2; i++)
    {
        raiseToADegree = raiseToADegree * num1;
    }
    return raiseToADegree;
}