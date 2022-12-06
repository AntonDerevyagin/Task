Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int number7 = 7;
int number23 = 23;
if (number % number7 == 0 & number % number23 == 0)
{
    Console.WriteLine($"Число {number} кратно {number7} и {number23}");
}
else if (number % number7 == 0)
{
    Console.WriteLine($"Кратно только {number7}");
}
else if (number % number23 == 0)
{
    Console.WriteLine($"Кратно только {number23}");
}
else
{
    Console.WriteLine("Не кратно не одному числу");
}