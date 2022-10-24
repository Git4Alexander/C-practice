// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void PrintMatrixDouble(double[,] matrix)
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

double[] AvgInColumn(int[,] matrix)
{
    int r = matrix.GetLength(0);
    double[] columnAvg = new double[r];


    // int avgJ = default;

    for (int j = 0; j < r; j++)
    {
        double sumJ = default;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {

            sumJ += matrix[i, j];
        }
        columnAvg[j] = Math.Round(sumJ / matrix.GetLength(1), 2);
        Console.Write($"{columnAvg[j]}   ");
        
    }

    return columnAvg;

}


int[,] array2D = CreateMartixRndInt(3, 3, 1, 5);
PrintMatrix(array2D);

Console.WriteLine();
Console.WriteLine("Средние значение элементов в столбце: ");

AvgInColumn(array2D);
