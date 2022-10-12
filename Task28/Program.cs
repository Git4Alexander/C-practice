// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number>=0)
{
int result = Factorial(number);
Console.WriteLine($"{number}! равно {result}");
}
else Console.WriteLine($"Введено некорректное значение");

int Factorial(int num)
{
    int i = 1;
    int sum = 1;
    while (i <= num)
    {
        sum = sum * i;
        i++;
    }
    return sum;
}