﻿Console.WriteLine("Введите координаты 1-ой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты 2-ой точки");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Координаты первой точки {x1},{y1},{z1}");
Console.WriteLine($"Координаты второй точки {x2},{y2},{z2}");

int A = x1 - x2;
int B = y1 - y2;
int C = z1 - z2;

double res = Math.Sqrt (A*A + B*B + C*C);
Console.WriteLine($"Расстояние между точками: {res}");