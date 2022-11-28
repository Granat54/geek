// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num)
{
    int count = 1;
    while (num > 10)
    {
        num = num / 10;
        count++;
    }
    return count;
}
if (number > 0) Console.WriteLine($"{number} -> {SumNumbers(number)}");
else Console.WriteLine("Введите натуральное число");