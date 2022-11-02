// Удалить столбец и строку у минимального элемента

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

int IndexMinInMatrix(int[,] matrix)
{
    int[] indexMin = new int[1];
    int minInMatrix = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minInMatrix)
            {
                minInMatrix = matrix[i, j];
                indexMin[0] = i;
                indexMin[1] = j;

            }
        }
    }
return indexMin;
}

int DelRowColumnMinElement(int[,] matrix, int[] arr)
{
    int newMatrix = new int[(matrix.GetLength(0) - 1), (matrix.GetLength(1) - 1)];
    for (int i = 0; i < newMatrix.GetLength(0); i++)
        if (i != arr[0])
        {
            for (int j = 0; j < newMatrixGetLenght(1); j++)
            {
                if (j != arr[1]) newMatrix[i, j] = matrix[i, j];
            }
        }
return newMatrix;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[,] array2D = CreateMartixRndInt(4, 3, 1, 9);
PrintMatrix(array2D);

Console.WriteLine();
int arrayMin = IndexMinInMatrix(array2D);
PrintArray(arrayMin);

Console.WriteLine();
int[,] arrayDel = DelRowColumnMinElement(array2D, arrayMin);
PrintMatrix(arrayDel);