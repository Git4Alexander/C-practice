// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndInt(int size, double min, double max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}


double[] DiffMaxMinInMassive(double[] array)
{
    double maxInMassive = default;
    double minInMassive = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxInMassive) maxInMassive = array[i];
        else if (array[i] < minInMassive) minInMassive = array[i];

    }
    return new double[] { maxInMassive, minInMassive };

}

double[] arr = CreateArrayRndInt(5, -9, 9);
PrintArray(arr);
double[] diffMaxMinInMassive = DiffMaxMinInMassive(arr);
Console.WriteLine($"Разница между максимальным элементом массива {diffMaxMinInMassive[0]} и минимальным {diffMaxMinInMassive[1]} равна {Math.Round(diffMaxMinInMassive[0] - diffMaxMinInMassive[1],1)}");
