// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.WriteLine("Введите число от которого будем искать данные в массиве (по умолчанию 10):");
int minNumberToFindInMassive = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число по которое будем искать данные в массиве (по умолчанию 100):");
int maxNumberToFindInMassive = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
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


int FindNumbersInDiapasone(int[] array, int minNumberToFind, int maxNumberToFind)
{
    int numberToFind = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= minNumberToFind && array[i] <= maxNumberToFind) numberToFind++;
    }
    return numberToFind;

}

int[] arr = CreateArrayRndInt(8, -1000, 1000);
PrintArray(arr);
int findNumbersInDiapasone = FindNumbersInDiapasone(arr, minNumberToFindInMassive, maxNumberToFindInMassive);
Console.WriteLine($"Число из диапазаона от {minNumberToFindInMassive} и {maxNumberToFindInMassive} встречаются в массиве {findNumbersInDiapasone} раз");