int number = new Random().Next(10, 100);
int digit1 = number /10;
int digit2 = number % 10;
Console.WriteLine($"Заданное число {number}, где первым числом является {digit1},  а вторым числом {digit2}");
int max = digit1;
if (max > digit2)
{
    Console.WriteLine($"Максимальным из двух чисел будет число {max}");
}
else
{
    max = digit2;
    Console.WriteLine($"Максимальным из двух чисел будет число {max}");
}