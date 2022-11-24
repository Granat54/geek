// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

void Poli(int num)
{
    int num2 = num % 10000;
    int num4 = num / 10;
    if (num/10000 == num%10 && num2/1000 == num4 % 10) Console.WriteLine($"{num} -> да");
    else Console.WriteLine($"{num} -> нет"); 
}

if (number>9999 && number < 100000) Poli(number);
else Console.WriteLine("Введено некорректное число");
    
