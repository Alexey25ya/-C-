// Напишите программу, которая принимает на вход 
//число (А) и выдаёт сумму чисел от 1 до А.

int GetLength(int num)
{

int i=0;
while(num>0)
{
i++;
num/=10;
}
return i;
}
int size = GetLength(766386);

Console.WriteLine (size);