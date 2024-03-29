﻿// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
            else Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine("|");
    }

}

int row = 3;
int column = 4;
int[,] array2D = CreateMatrixRndInt(row, column, 1, 9);
PrintMatrix(array2D);

Console.WriteLine("Введите координаты числа: ");
Console.Write("Строка:");
int numberRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбец:");
int numberColumn = Convert.ToInt32(Console.ReadLine());

if (numberRow< row && numberRow>=0 && numberColumn<column&& numberColumn>= 0) Console.WriteLine($"{numberRow},{numberColumn} -> {array2D[numberRow, numberColumn]}");
else Console.WriteLine($"{numberRow},{numberColumn} -> такого элемента в массиве нет");