// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

bool PresentNumber(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (num == array[i]) return true;

    }
    return false;
}

bool PresentNumber1(int[] array, int num)
{
    bool res = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (num == array[i])
        {
            res = true;
            break;
        }
    }
    return res;
}



Console.WriteLine("Введите искомое число");
int number = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArrayRndInt(12, -10, 10);

PrintArray(arr);
Console.Write($"{number} - > ");
bool result = PresentNumber(arr, number);
Console.Write(result ? "Да" : "Нет");





