// Задача 32: Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] fillArray (int[] arr)
{
int length = arr.Length;
int i= 0;
while (i < length)
{
arr[i] = new Random().Next(0,11 );
i++;

}
return arr;
}



int[]array = new int[10];
int j=0;


foreach (int item in fillArray(array ))
{
    Console.Write(array[j]+" | ");
    array[j] =  item*-1;
    j++;

}
Console.WriteLine();
Console.WriteLine(string.Join(" | ", array));

