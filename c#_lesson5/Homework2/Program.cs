﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt (int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }        
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length -1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

int CountOdd(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 !=0) count = count+ array[i];
    }
    return count;
}


int[] arr = CreateArrayRndInt(4, 100, 1000);
PrintArray(arr);
Console.WriteLine($" -> {CountOdd(arr)}");
