int number = new Random().Next(100, 1000);

Console.WriteLine(number);

int RemoveSecond(int num)
{
    int firstDigit = number / 100;
    int thirdDigit = number % 10;
    int resuslt = firstDigit*10 + thirdDigit;
    return resuslt;
}
int remove = RemoveSecond(number);
Console.WriteLine(remove);