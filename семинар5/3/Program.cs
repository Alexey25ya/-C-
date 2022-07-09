// Задача 33: Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.

int[] fillArray(int[] arr)
{
    int length = arr.Length;
    int i = 0;
    while (i < length)
    {
        arr[i] = new Random().Next(0, 11);
        i++;

    }
    return arr;
}

int[] array = new int[10];
fillArray(array);

string findnum(int[] arr1, int num)
{
    for (int j = 0; j < arr1.Length; j++)
    {
        if (arr1[j] == num)
            return "prisutstvuet";
    }
    return "otsutstvuet";
}
int number = 5;
Console.WriteLine(string.Join(" | ", array));
Console.WriteLine(findnum(array, number));