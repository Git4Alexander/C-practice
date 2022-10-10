// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125



Console.Write("Введите целое число от 1 и больше: ");
int n = Convert.ToInt32(Console.ReadLine());

void TripleTable(int num)
{
    int i = 1;
    while (i <= num)
    {
        Console.WriteLine($"{i,2}   ->   {i * i * i,2} ");
        i++;
    }
}

if (n > 0) TripleTable(n);
else Console.WriteLine("Введено некорректное число");