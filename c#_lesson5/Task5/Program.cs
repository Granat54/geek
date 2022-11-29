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


void MultipleArray(int[] array)
{
    int iMax = array.Length - 1;
    Console.Write("[");
    if (array.Length % 2 == 0)
    {
        for (int i = 0; i < (array.Length) / 2; i++)
        {
            array[i] = array[i] * array[iMax];
            if (i < array.Length / 2 - 1) Console.Write($"{array[i]}, ");
            else Console.Write($"{array[i]}");
            iMax--;
        }
    }
    else
    {
        for (int i = 0; i < (array.Length - 1) / 2; i++)
        {
            array[i] = array[i] * array[iMax];
            if (i < array.Length / 2 - 1) Console.Write($"{array[i]}, ");
            else
            {
                Console.Write($"{array[i]}, ");
                Console.Write($"{array[i + 1]}");
            }
            iMax--;
        }
        Console.WriteLine("]");
    }
}
int[] arr = CreateArrayRndInt(11, -9, 9);
PrintArray(arr);
MultipleArray(arr);