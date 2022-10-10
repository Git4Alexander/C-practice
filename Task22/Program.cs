// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите целое число от 1 и больше: ");
int n = Convert.ToInt32(Console.ReadLine());

void SquareTable(int num)
{
    int i = 1;
    while (i <= num)
    {
        Console.WriteLine($"{i,2}   ->   {i * i,2} ");
        i++;
    }
}

if (n>0) SquareTable(n);
else Console.WriteLine("Введено некорректное число");