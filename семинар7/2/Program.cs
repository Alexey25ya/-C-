// Задача 48: Задайте двумерный массив размера m на n, каждый элемент 
//в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

int m = 6;
int n = 5;

int[,] gatArray(int mLocal, int nLocal, int min, int max)
{
int[,] result = new int[mLocal, nLocal];
for (int i = 0; i < mLocal; i++)
{
for (int j = 0; j < nLocal; j++)
{
result[i, j] = i+j;
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