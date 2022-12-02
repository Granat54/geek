// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите число M:");
int numberM = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRndInt (int size)
{
    int[] array = new int[size];
    
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите число:");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }        
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length -1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

int CountPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count+= 1;
    }
    return count;
}

int[] arr = CreateArrayRndInt(numberM);
int result = CountPositive(arr);
PrintArray(arr);
Console.Write($"-> {result}");