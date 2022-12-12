// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. Выполнить с помощью рекурсии.



Console.WriteLine("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

void NaturalNum (int num)
{
    if (num == 0) return ;
    NaturalNum (num-1);
    Console.Write($"{num} "); 
}

if (numberN > 0)NaturalNum(numberN);
else Console.WriteLine("Введенное число не является натуральным");