// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


int number = InputIntData("Введите число");
int summ = SumOfDigits(number);
Console.WriteLine(summ);

int SumOfDigits(int num)
{
int sum = num % 10;
if(num > 0) sum += SumOfDigits(num / 10);
return sum;
}