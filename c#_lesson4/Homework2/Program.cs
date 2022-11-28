// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigit(int num)
{
    int sum = 0;
    if (num < 0) num = num * -1;
    while (num > 10) 
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    sum = sum + num;
    return sum;
}

if (number > 0 || number < 0)
{
    int result = SumDigit(number);
    Console.WriteLine($"{number} -> {result}");
}
else Console.WriteLine("0 -> 0");