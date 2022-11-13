Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int b = number * (-1);
while 
    (b <= number){
        Console.Write($"{b} ");
        b = b + 1;
    }

   