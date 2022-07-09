// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

int[] getArray(int n)
{
int[] arr = new int[n];
for (int i = 0; i < arr.Length; i++)
{
arr[i] = new Random().Next(-9, 10);
Console.Write(arr[i]+" | ");
}
return arr;
}


int pos = 0;
int neg = 0;

foreach (int item in getArray(12))
{
    
pos += item > 0 ? item : 0;
neg += item < 0 ? item : 0;
}

Console.WriteLine($"   pos = {pos} neg = {neg}");