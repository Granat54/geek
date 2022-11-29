// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndInt (int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1) + rnd.NextDouble(); 
        array[i] = Math.Round(array[i], 1, MidpointRounding.ToZero);
        
    }        
    return array ;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length -1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

double Differense(double[] array)
{
    double min = array[0];
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
        else if(array [i] < min) min = array[i];
    }
    double result = max - min;
    result = Math.Round(result, 1, MidpointRounding.AwayFromZero);
    return result;
}

double[] arr = CreateArrayRndInt(4, 1, 100);
PrintArray(arr);
Console.WriteLine($" -> {Differense(arr)}");
