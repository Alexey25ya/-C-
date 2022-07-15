// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
int m = 6;
int n = 6;

int[,] gatArray(int mLocal, int nLocal, int min, int max)
{
int[,] result = new int[mLocal, nLocal];
for (int i = 0; i < mLocal; i++)
{
for (int j = 0; j < nLocal; j++)
{
result[i, j] = new Random().Next(min, max + 1);
}
}
return result;
}

void printArray(int[,] inArray)
{
for (int i = 0; i < inArray.GetLength(0); i++)
{
for (int j = 0; j < inArray.GetLength(1); j++)
{
Console.Write($"{inArray[i,j]} ");
}
Console.WriteLine();
}
}

int[,] array = gatArray(m, n, 0, 9);
printArray(array);