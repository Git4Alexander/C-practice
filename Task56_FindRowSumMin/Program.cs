// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[,] MatrixSumRows(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0), 1];
    for (int m = 0; m < newMatrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
            if (n == 0) newMatrix[m, n] = m;
            else
            {
                for (int i = 0; i < matrix.GetLength(0); i++) // rows (0) = matrix.GetLength(0)
                {
                    int sum = default;
                    for (int j = 0; j < matrix.GetLength(1); j++) //columns (1) = matrix.GetLength(1)
                    {
                        sum = sum + matrix[i, j];
                        Console.WriteLine(sum);
                    }
                    newMatrix[m,n] = sum;

                }
            }
        return newMatrix;
    }
}

int[,] array2D = CreateMartixRndInt(5, 5, 1, 9);
PrintMatrix(array2D);

Console.WriteLine();
int[,] matrixSumRows = MatrixSumRows(array2D);
PrintMatrix(matrixSumRows);