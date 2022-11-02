// Дан двумерный массив. СОставить частотный словарь, сколько число встречается раз в массиве


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

int[] MatrixToArray(int[,] matrix)

{
    int size = matrix.GetLength(0) * matrix.GetLength(1);
    int[] arrayFromMatrix = new int[size];
    int count = 0;
    // Console.WriteLine(size);
    // int sizeJ=matrix.GetLength(0);
    // Console.WriteLine(sizeJ);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        // int count = matrix.GetLength(1) * i;
        // Console.WriteLine(count);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arrayFromMatrix[(count)] = matrix[i, j];
            count++;
        }

    }
    return arrayFromMatrix;
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

void HowManyNumbersInArray(int[] array)
{
    int count = 1;
    int numForCount = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (numForCount == array[i]) count++;
        else
        {
            Console.WriteLine($"{numForCount} --> {count}");
            numForCount = array[i];
            count = 1;
        }
        
    }
    Console.WriteLine($"{numForCount} --> {count}");
}

int[,] array2D = CreateMartixRndInt(5, 6, 1, 9);
PrintMatrix(array2D);

Console.WriteLine();
int[] matrixToArray = MatrixToArray(array2D);
PrintArray(matrixToArray);

Console.WriteLine();
Array.Sort(matrixToArray);
PrintArray(matrixToArray);

HowManyNumbersInArray(matrixToArray);