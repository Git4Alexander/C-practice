int number = new Random().Next(100, 1000);
Console.WriteLine($"Случафное число от 100 до 999 => {number}");
int firstDigit = number / 100;
int thirdDigit = number % 10;
Console.WriteLine($"Первое число {number} = {firstDigit}");
Console.WriteLine($"Третье число {number} = {thirdDigit}");
// Console.WriteLine (firstDigit,secondDigit);
//int result (firstDigit*10+secondDigit);
Console.WriteLine($"Цифра без среднего числа {number} = {firstDigit * 10 + thirdDigit}");

