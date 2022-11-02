// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

if (numberM > numberN) 
{
int summ = NaturalNumbersMtoN(numberM, numberN);
Console.Write($"сумма чисел от {numberN} до {numberM} равна {summ}");
}

else 
{int summ = NaturalNumbersMtoN(numberN, numberM);
Console.Write($"сумма чисел от {numberM} до {numberN} равна {summ}");
}

int NaturalNumbersMtoN(int numM, int numN)
{
    int sum = numM;
    if (numM > numN)
        sum += NaturalNumbersMtoN(numM - 1, numN);
    // Console.Write($"{numM} ");
    return sum;
}