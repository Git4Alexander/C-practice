// Задайте двумерный массив, замените строки на столбцы.

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

int[,] RowsToColumns(int[,] matrix)
{
    int[,] newArray = new int[matrix.GetLength(1), matrix.GetLongLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)

    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newArray[i, j] = matrix[j, i];
        }

    }
    return newArray;
}

bool CheckIsameJ(int[,] matrix)
{
   return matrix.GetLength(0) == matrix.GetLength(1);
}

int[,] array2D = CreateMartixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);

Console.WriteLine();
if (CheckIsameJ(array2D))
    PrintMatrix(RowsToColumns(array2D));
else Console.WriteLine("Невозможно заменить строки на столбцы");


