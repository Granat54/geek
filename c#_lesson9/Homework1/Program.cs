﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

void NaturalNum (int num)
{
    if (num == 0) return ;
    Console.Write($"{num} ");
    NaturalNum (num-1); 
}

if (numberN > 0)NaturalNum(numberN);
else Console.WriteLine("Введенное число не является натуральным");