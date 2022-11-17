Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());

bool MultiplicityTwoDigits (int num, int num1, int num2)
{
    return num % num1 == 0 && num % num2 == 0;
}

bool result = MultiplicityTwoDigits(number, 7, 23);

string resultStr = result ? "Да" : "Нет";
Console.WriteLine($" {number} -> {resultStr}");