// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.WriteLine("Ввведите целое пятизначное положительное число ");
int number = Convert.ToInt32(Console.ReadLine());

bool Paliander(int num)
{
    int num1 = (num / 10000) % 10;
    int num2 = (num / 1000) % 10;
    int num4 = (num / 10) % 10;
    int num5 = num % 10;

    return (num1 == num5 && num2 == num4);
}

if (number>100000 || number < 10000) Console.WriteLine($"число {number} не соответстсует условию задачи"); 
else if (Paliander(number)) Console.WriteLine($"число {number} является полиндромом");
else Console.WriteLine($"число {number} НЕ является полиндромом");
