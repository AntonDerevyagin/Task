// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.WriteLine("Введите число дня недели");
int days = Convert.ToInt32(Console.ReadLine());
if (days == 1)
{
    Console.WriteLine("Понедельник ");
}
if (days == 2)
{
    Console.WriteLine("Вторник");
}
if (days == 3)
{
    Console.WriteLine("Среда ");
}
if (days == 4)
{
    Console.WriteLine("Четверг ");
}
if (days == 5)
{
    Console.WriteLine("Пятница");
}
if (days == 6)
{
    Console.WriteLine("Суббота ");
}
if (days == 7)
{
    Console.WriteLine("Воскресенье");
}
if (days > 7)
{
    Console.WriteLine("Дня недели не существует");
}

