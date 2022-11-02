// Задайте двумерный массив. Напишите программу, которая меняет первую и последнюю строку массива.

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

void ChangeRows(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++) 

    {
        int obj = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = obj;
    }
}

int[,] array2D = CreateMartixRndInt(5, 5, 1, 9);
PrintMatrix(array2D);

ChangeRows(array2D);
Console.WriteLine();
PrintMatrix(array2D);
