// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

// Через ветвление:
// Console.WriteLine("Ввведите целое число ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number % 7 == 0 && number % 23 == 0) Console.WriteLine($"{number}, кратно и 7 и 23");
// else Console.WriteLine($"{number}, НЕ кратно 7 или 23");

// через метод
Console.WriteLine("Ввведите целое число ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввведите делитель 1 ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввведите делитель 2 ");
int number3 = Convert.ToInt32(Console.ReadLine());

bool IsAliquot7and23(int arg)
{
    return arg % number2 == 0 && arg % number3 == 0;
}

if (IsAliquot7and23(number1)) Console.WriteLine($"{number1}, кратно и {number2} и {number3}");
else Console.WriteLine($"{number1}1, НЕ кратно {number2} или {number3}");