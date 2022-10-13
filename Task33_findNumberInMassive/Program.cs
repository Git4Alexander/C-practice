// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.WriteLine("Введите число, которое будем искать в массиве: ");
int numberToFind = Convert.ToInt32(Console.ReadLine());

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


bool FindNumberInMassive(int[] array, int arg)
{
    bool checkNum = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == arg) 
        {checkNum = true;
        break;
        }
    }
    return checkNum;

}

int[] arr = CreateArrayRndInt(6, -2, 2);
PrintArray(arr);
bool findNumberInMassive = FindNumberInMassive(arr, numberToFind);
Console.WriteLine($"Есть ли число {numberToFind} в массиве: {findNumberInMassive}");