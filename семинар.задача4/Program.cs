﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());

if (n=>100 && n<=999)
{
  Console.WriteLine(n%10);
}
else Console.WriteLine("Error");
