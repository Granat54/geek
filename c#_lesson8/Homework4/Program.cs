﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateMatrixRndInt(int rows, int columns, int depth)
{
    int[,,] matrix = new int[rows, columns, depth];
    int y=10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = y;
                y++;
            }
        }

    }
    return matrix;
}


void PrintMatrix3D(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (k < matrix.GetLength(2) - 1) Console.Write($"{matrix[i, j, k], 4}, ");
            else Console.Write($"{matrix[i, j, k], 4}");
            }
        }
        Console.WriteLine("|");
    }

}


int[,] ReverceMatrix3DTo2D(int[,,] matrix)
{
    int x = 0;
    int y = 0;
    int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)*matrix.GetLength(2)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           for (int k = 0; k < matrix.GetLength(2); k++)
           {
                newMatrix[x,y]= matrix[i,j,k]; 
                y++;
                
           }
           
        }
        x++;
        y=0;
    }
    return newMatrix;
}


void PrintMatrix(int[,] matrix, int[,,]matrix1)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int y = 0;
        Console.Write("|");
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            
            for (int k = 0; k < matrix1.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j+k+y]}({i},{j},{k})  ");
                
            }
            y+=matrix1.GetLength(2)-1;
            
            
        }
        Console.WriteLine("|");
    }

}



int[,,] array3D = CreateMatrixRndInt(4, 4, 4);
PrintMatrix3D(array3D);
int[,] arr = ReverceMatrix3DTo2D(array3D);
PrintMatrix(arr, array3D);

