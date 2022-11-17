int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 --> {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа --> {firstDigit}");
else Console.WriteLine($"Наибольшая цифра числа --> {secondDigit}");

Console.WriteLine($"Наибольшая цифра числа --> {Math.Max(firstDigit, secondDigit)}");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    if (firstDigit > secondDigit) return firstDigit;
    return secondDigit;
 }

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа --> {maxDigit}");
