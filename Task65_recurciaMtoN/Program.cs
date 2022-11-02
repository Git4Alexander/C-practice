// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


// Console.WriteLine("Введите натуральное число M: ");
// int numberM = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите натуральное число N: ");
// int numberN = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();
// if (numberM > numberN) NaturalNumbersFromMtoN(numberM, numberN);
// else NaturalNumbersFromMtoN(numberN, numberM);

// void NaturalNumbersFromMtoN(int numM, int numN)
// {

//     if (numM == numN - 1) return;
//     NaturalNumbersFromMtoN(numM - 1, numN);
//     Console.Write($"{numM} ");

// }



Console.WriteLine("Введите первое число");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Вариант решения первый:");
// Console.WriteLine();
if (numberM > numberN) NaturalNumbersMtoN(numberM, numberN);
else NaturalNumbersMtoN(numberN, numberM);

void NaturalNumbersMtoN(int numM, int numN)
{

    if (numM == numN - 1) return;
    NaturalNumbersMtoN(numM - 1, numN);
    Console.Write($"{numM} ");
}

Console.WriteLine();
Console.WriteLine("Вариант решения второй:");
NaturalNumbersFromMToN(numberM, numberN);

void NaturalNumbersFromMToN(int numM, int numN)
{
    if (numM < numN)
    {
        Console.Write($"{numM} ");
        NaturalNumbersFromMToN(numM + 1, numN);


    }
    if (numM > numN)
    {
        Console.Write($"{numM} ");
        NaturalNumbersFromMToN(numM - 1, numN);
    }
    if (numN == numM) Console.Write($"{numM} ");
}