// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.

bool IsTriangle(int a, int b,int c)
{
    if(a+b>c && a+c>b && b+c>a)
    {
        return true;
    }
    return false;
}
Console.WriteLine(IsTriangle(5,4,7));