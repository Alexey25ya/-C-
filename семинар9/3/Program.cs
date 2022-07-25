// Задача 69: Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.


 int GetResult(int a, int b)
{
if (b == 0)
{
return 1;
}
return a * GetResult(a, b - 1);

}
Console.WriteLine(GetResult(3, 4));
