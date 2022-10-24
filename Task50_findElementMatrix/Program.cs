// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет


int[,] CreateMartixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) // rows (0) = matrix.GetLength(0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //columns (1) = matrix.GetLength(1)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("|");
    }
}

bool FindIndexInMatrix(int[,] matrix, int indexI, int indexJ)
{
    return (indexI >= 0 && indexI < matrix.GetLength(0) && indexJ >= 0 && indexJ < matrix.GetLength(1));

}

Console.WriteLine("Введите номер строки и номер стобца матрицы:");
int iI = Convert.ToInt32(Console.ReadLine());
int iJ = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMartixRndInt(5, 5, -10, 10);
PrintMatrix(array2D);

Console.WriteLine();
if (FindIndexInMatrix(array2D, iI, iJ))
    Console.WriteLine($"Элемент массива по указанным координатам [{iI},{iJ}]) является {array2D[iI, iJ]}");
else Console.WriteLine("такого элемента в массиве нет");