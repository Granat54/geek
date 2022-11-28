// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num)
{
    int mult = 1;
    int count = 1;
    while (count <= num )
    {
        mult = mult * count;
        count ++;
    }
    return mult;
}
if (number > 0) Console.WriteLine($"{number} -> {SumNumbers(number)}");
else Console.WriteLine("Введите натуральное число");