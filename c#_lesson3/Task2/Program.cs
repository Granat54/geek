﻿// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");
int quarter = Convert.ToInt32(Console.ReadLine());

string Quarter(int x)
{
    if(x == 1) return "Указанной четверти соответствуют координаты -> x>0 и y>0";
    if(x == 2) return "Указанной четверти соответствуют координаты -> x<0 и y>0";
    if(x == 3) return "Указанной четверти соответствуют координаты -> x<0 и y<0";
    if(x == 4) return "Указанной четверти соответствуют координаты -> x>0 и y<0";
    return "Введенное число не соответствует четверти";
}
Console.WriteLine(Quarter(quarter));