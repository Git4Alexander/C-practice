﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int res = num1 % 2;
if (res==0) Console.WriteLine("ДА");
else Console.WriteLine("НЕТ");