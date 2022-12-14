// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// Без метода

// int[] arr = new int[8];

// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = new Random().Next(0, 2);
//     Console.Write(arr[i]);
//     Console.Write(" ");
// }


// С методом версия 1

// int[] array = new int[8];
// int[] resArray = GetArray(array);
// PrintArray(array);

// int[] GetArray(int[] arr)
// {
//     int length = arr.Length;
//     for (int i = 0; i < length; i++)
//     {
//         arr[i] = new Random().Next(0, 2);
//     }
//     return arr;
// }
// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// С методом версия 2

int[] array = new int[8];
GetArray(array);
PrintArray(array);


void GetArray(int[] arr)
{
    int length = arr.Length;
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
}
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}