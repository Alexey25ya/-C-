﻿// название дня недели по заданному числу
int num = 0;
Console.WriteLine("Введите число от 1 до 7");
num = Convert.ToInt32(Console.ReadLine());

switch (num)
{
  case 1: {
    Console.WriteLine("Пн");
    break;
 } 
 case 2: {
    Console.WriteLine("Вт");
    break;
 }
  case 3: {
    Console.WriteLine("Ср");
    break;
 }
  case 4: {
    Console.WriteLine("Чт");
    break;
 }
  case 5: {
    Console.WriteLine("Пт");
    break;
 }
  case 6: {
    Console.WriteLine("Сб");
    break;
 }
  case 7: {
    Console.WriteLine("Вс");
    break;
 }
}