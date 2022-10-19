// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

// // Вариант без метода
// Console.Write("введите количество элементов массива:\t");
// int arraySize = int.Parse(Console.ReadLine());

// int[] array = new int[arraySize];


// for (int i = 0; i < arraySize; i++)
// {
//     Console.WriteLine($"\nВведите элемент массива {i + 1}:\t");
//     array[i] = int.Parse(Console.ReadLine());
// }

// Console.WriteLine("\nВывод массива");

// for (int i = 0; i < arraySize; i++)
// {
//     Console.Write(array[i]);
// }
// Console.ReadLine();

// //
Console.Write("введите количество элементов массива:\t");
int arraySize = int.Parse(Console.ReadLine());

int[] arr = CreateArrayByUser(arraySize);
PrintArray(arr);
int arrayNumbersMoreZero = NumbersMoreZero (arr);
Console.Write($"Из {arraySize} цифр в массиве больше нуля: {arrayNumbersMoreZero}");

int[] CreateArrayByUser (int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
{
    Console.WriteLine($"\nВведите элемент массива {i+1}:\t");
    array[i]=int.Parse(Console.ReadLine());
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

int NumbersMoreZero(int[] array)
{
    int numbersMoreZero = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) numbersMoreZero++;
        
    }
    return numbersMoreZero;

}