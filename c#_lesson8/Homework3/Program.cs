// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("|");
    }

}

int[,] MultipleMatrix(int[,] matrix, int[,] matrix1)
{
    int[,] newMatrix = new int[matrix.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                newMatrix[i, j] += matrix[i, k] * matrix1[k, j];
            }
        }
    }
    return newMatrix;
}



int[,] array = CreateMatrixRndInt(3, 2, 1, 9);
PrintMatrix(array);

Console.WriteLine();

int[,] array2D = CreateMatrixRndInt(2, 3, 1, 9);
PrintMatrix(array2D);

Console.WriteLine();

if (array.GetLength(1) == array2D.GetLength(0)) 
{
    int[,] newArray = MultipleMatrix(array, array2D);
    PrintMatrix(newArray);
}
else Console.WriteLine("Данные матрицы нельзя перемножить");