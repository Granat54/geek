// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на 
// выходе показывает вторую цифру этого числа. Выполнить с помощью числовых 
// операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int num)
{
    int num1 = number / 10;
    int num2 = num1 % 10;
    return num2;
}

if (number > 99 && number < 1000) Console.WriteLine($"{number} -> {SecondDigit(number)}");
else Console.WriteLine("Число не трехзначное");

