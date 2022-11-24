// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты двух точек");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Length(int num1, int num2, int num3, int num4, int num5, int num6)
{
    return Math.Sqrt((num4-num1)*(num4-num1)+(num5-num2)*(num5-num2)+(num6-num3)*(num6-num3));
}
double n = Length(x1, y1, z1, x2, y2, z2);
double res = Math.Round(n, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками = {res}");
