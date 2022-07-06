// Напишите программу, которая принимает на 
//вход число и выдаёт количество цифр в числе.

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