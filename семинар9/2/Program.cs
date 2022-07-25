// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
 int ReturnSum(int n)
{
if (n != 0) return n % 10 + ReturnSum(n / 10);

else return 0;
}

Console.WriteLine(ReturnSum(5124));
