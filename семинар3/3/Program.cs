﻿// Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 2D пространстве.

Console.WriteLine("Введите координаты первой точки:");
// int x1, y1 = Convert.ToInt32(Console.ReadLine());
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки:");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());

// Math.Sqrt(Math.Pow(x2-x1, 2)+ Math.Pow(y2-y1, 2));


double newPoint()
{
    double newPoint = Math.Sqrt(Math.Pow(x2-x1, 2)+ Math.Pow(y2-y1, 2));
    return newPoint;
}


Console.WriteLine(newPoint());
