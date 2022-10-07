// int number = new Random().Next(10, 100);
// Console.WriteLine($"Случафное число от 10 до 99 => {number}");
// int firstDigit = number / 10;
// int secondDigit = number % 10;

// Первый способ 
//if (firstDigit == secondDigit) System.Console.WriteLine("Цифры равны");
// else if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {number} = {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа {number} = {secondDigit}");

// Второй способ
// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine ($"Наибольшая цифра числа {number} = {maxDigit}");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    // if (firstDigit > secondDigit) return firstDigit;
    // return secondDigit;
    // if (firstDigit == secondDigit) return 0;
    if(IsEqualDigits(firstDigit,secondDigit)) return 0;
        
   
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

bool IsEqualDigits(int num1, int num2)
{
    return num1 == num2;
}

int number = new Random().Next(10, 100);
int maxDigit = MaxDigit (number);
string result = maxDigit > 0 ? maxDigit.ToString() : "Цифры равны";
Console.WriteLine ($"Наибольшая цифра числа {number} = {result}");

// int result = MaxDigit (number);
// Console.WriteLine ($"Наибольшая цифра числа {number} = {result}");