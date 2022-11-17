// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите число, соответствующее дню недели");
int day = Convert.ToInt32(Console.ReadLine());

bool Weekend(int num)
{
    return num == 6 || num == 7;
}

if (day > 0 && day < 8)
{
    bool res = Weekend(day);
    Console.WriteLine(res ? "Да" : "Нет");
}
else Console.WriteLine($"Число {day} не соответствует дню недели");

