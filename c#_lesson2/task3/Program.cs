Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

int number3 = number1 % number2;
if (number3 == 0) Console.WriteLine("Кратно");
else Console.WriteLine($"Не кратно, остаток {number3}");


