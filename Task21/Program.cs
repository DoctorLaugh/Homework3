﻿Console.Clear();
Console.WriteLine("Введите координату х первой точки");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z первой точки");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату х второй точки");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z второй точки");
int z2 = int.Parse(Console.ReadLine());
double dist = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1-z2), 2));
Console.WriteLine($"Расстояние между точками - {dist:f2}");