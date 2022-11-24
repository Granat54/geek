// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты двух точек");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Length(int num1, int num2, int num3, int num4)
{
    return Math.Sqrt((num3-num1)*(num3-num1)+(num4-num2)*(num4-num2));
}
double n = Length(x1, y1, x2, y2);
double res = Math.Round(n, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками = {res}");
