// Наибольшее из 9 чисел
int Max(int arg1,int arg2,int arg3)
{
    int result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result;
}

Console.WriteLine("Введите 1 число");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число");
int a3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 4 число");
int a4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 5 число");
int a5 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 6 число");
int a6 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 7 число");
int a7 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 8 число");
int a8 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 9 число");
int a9 = Convert.ToInt32(Console.ReadLine());

int Max1=Max(a1,a2,a3);
int Max2=Max(a4,a5,a6);
int Max3=Max(a7,a8,a9);
int max=Max(Max1,Max2,Max3);
Console.Write("max= ");
Console.Write(max);