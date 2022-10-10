Console.WriteLine("Введите номер четверти от 1 до 4");
Console.Write("Введите четверть: ");
int quarter = Convert.ToInt32(Console.ReadLine());
string result = QuarterStr(quarter);
Console.WriteLine(result);

// int quarter = Diapasone(quarter);

// Console.WriteLine(quarter < 1||quarter > 4 ? "Введены некорректные координаты " : $"доступные координаты для четверти {quarter}");

// вариант без метода
void Diapasone(int quarter)
{
    if (quarter == 1) Console.WriteLine("x > 0 и y > 0");
    else if (quarter == 2) Console.WriteLine("x < 0 и y > 0");
    else if (quarter == 3) Console.WriteLine("x < 0 и y < 0");
    else if (quarter == 4) Console.WriteLine("x > 0 и y < 0");
    else if (quarter == 4) Console.WriteLine("x > 0 и y < 0");
    else Console.WriteLine("Введены некорректные координаты ");

}

Diapasone(quarter);

// вариант с методом
string QuarterStr(int quart)
{
    if (quart == 1) return "x > 0 и y > 0";
    if (quart == 2) return "x < 0 и y > 0";
    if (quart == 3) return "x < 0 и y < 0";
    if (quart == 4) return "x > 0 и y < 0";
    return "Введено некорректное число";
}

