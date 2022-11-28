// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число А");
int number = Convert.ToInt32(Console.ReadLine());

int Sum (int num)
{
    int num1 = 1;
    int sum = 0;
    while (num1 <= num)
    {
        sum = sum + num1;
        num1 ++;
    }
return sum;
}

if (number>0) Console.WriteLine($"{number} -> {Sum(number)}");
else Console.WriteLine("Введено некорректное число");