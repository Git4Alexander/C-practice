// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Ввведите целое положительное число ");
int number = Convert.ToInt32(Console.ReadLine());


if (number < 100) Console.WriteLine("Третье цифры нет");
else
{
int i = 10;

while (number > i)
    {
    i=i*10;
    }
Console.WriteLine($"Делитель = {i}");
int thirdDigit = (number*1000 / i) % 10;
Console.WriteLine($"Третья цифра числа = {thirdDigit}");
Console.WriteLine($"Проверка = {number*1000 / i}");
}
