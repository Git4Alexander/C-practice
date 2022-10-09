// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Ввведите номер дня недели от 1 до 7 ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 7 || number < 1) Console.WriteLine($"номер дня недели {number} не существует");
else
{
    bool IsArestDay(int num)
    {
    return num == 6 || num == 7;
    }
    if (IsArestDay(number)) Console.WriteLine($"номер дня недели {number} является выходным");
    else Console.WriteLine($"номер дня недели {number} НЕ является выходным");
}
