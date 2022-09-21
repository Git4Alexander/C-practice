Console.Write("Введите целое число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите квадрат этого числа: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int square = numberB * numberB;

if (numberA == square)
{
    Console.WriteLine("Верно");
}
else
{
    Console.WriteLine($"Не верно! Квадрат числа {numberB} = {square} ");
}
