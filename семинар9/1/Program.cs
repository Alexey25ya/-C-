// Задача 63: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от 1 до N.

string RNumber(int a, int n)
{

    if (a == n)
    {
        return n.ToString();
    }
    else
    {
        return a.ToString() + " " + RNumber(a += 1, n);
    }
}
Console.WriteLine(RNumber(1,5));