// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит 
// число A в натуральную степень B.
// 3, 5 -> 243
// 2, 4 -> 16

Console.WriteLine("Введите два числа");
Console.Write("A:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("B:");
int number2 = Convert.ToInt32(Console.ReadLine());

int Multi(int num1, int num2)
{
    int index = 1;
    int result = 1;
    while (index <= num2)
    {
        result = result * num1;
        index++;
    }
    return result;
}

if (number2 > 0)
{
    int res = Multi(number1, number2);
    Console.WriteLine($"{number1}, {number2} -> {res}");
}
else Console.WriteLine("Число B должно быть натуральным");