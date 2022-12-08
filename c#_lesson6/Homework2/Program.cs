// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите число B1: ");
double numberB1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B2: ");
double numberB2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число K1: ");
double numberK1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число K2: ");
double numberK2 = Convert.ToInt32(Console.ReadLine());

double FindX(double num1, double num2, double num3, double num4)
{
    double numX = (num1 - num2) / (num4 - num3);
    return numX;
}

double FindY(double num1, double num2, double numX)
{
    double numY = num2 * numX + num1;
    return numY;
}


double numberX = FindX(numberB1, numberB2, numberK1, numberK2);
double numberY = FindY(numberB1, numberK1, numberX);

Console.Write($"b1 = {numberB1}, k1 = {numberK1}, b2 = {numberB2}, k2 = {numberK2} ");
Console.WriteLine($"-> ({numberX} ; {numberY} )");