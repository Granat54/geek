// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Число: ");
int num = Convert.ToInt32(Console.ReadLine());

string ConvertToBin(int n)
{
string result = string.Empty;
while (n > 0)
{
result = n % 2 + result;
n = n / 2;
}
return result;
}

Console.WriteLine(ConvertToBin(num));

// string k = "один";
// string l = "два";

// Console.WriteLine(l+k);