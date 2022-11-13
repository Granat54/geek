Console.WriteLine("Нахождение последней цифры в трехзначном числе");
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
if (number < 1000 && number > 99)
{
    Console.WriteLine(number % 10);
}
else
{ Console.WriteLine("Трехзначное число, пожалуйста ");}