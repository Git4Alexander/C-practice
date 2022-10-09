int number1 = new Random().Next(1, 100);
Console.WriteLine($"Первое число => {number1}");
int number2 = new Random().Next(1, 10);
Console.WriteLine($"Второе число, делитель => {number2}");

int res = number1 % number2;
// Console.WriteLine($"Остаток от деления => {res}");

if (res == 0) Console.WriteLine($"Число {number1} кратно числу {number2}");
else Console.WriteLine($"Число {number1} НЕ кратно числу {number2}, остаток от деления {res}");