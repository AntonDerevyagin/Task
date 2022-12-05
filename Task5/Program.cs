Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
int res = number1 % number2;
if (number1 % number2 == 0)
{
    Console.WriteLine($"кратно {res}");
}
else
{
    Console.WriteLine($"Не кратно {res}");
}