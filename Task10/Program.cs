// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// int number = new Random().Next(100, 1000);
// Console.WriteLine($"Случафное число от 100 до 999 => {number}");

Console.WriteLine("Ввведите целое трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());

int firstDigit = number / 100;
int secondDigit = number / 10 - firstDigit * 10;

Console.WriteLine($"Вторая цифра числа {number} это {secondDigit}");

// int thirdDigit = number % 10;
// Console.WriteLine($"Первое число {number} = {firstDigit}");
// Console.WriteLine($"Третье число {number} = {thirdDigit}");
// // Console.WriteLine (firstDigit,secondDigit);
// //int result (firstDigit*10+secondDigit);
// Console.WriteLine($"Цифра без среднего числа {number} = {firstDigit * 10 + thirdDigit}");