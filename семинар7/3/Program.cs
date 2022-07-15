// Задача 49: Задайте двумерный массив. Найдите элементы, 
//у которых оба индекса чётные, и замените эти элементы на их квадраты.

int m = 5;
int n = 6;

int[,] getArray(int mLocal, int nLocal)
{
    int[,] result = new int[mLocal, nLocal];
    for (int i = 0; i < mLocal; i++)
    {
        for (int j = 0; j < nLocal; j++)
        {
            result[i, j] = new Random().Next(1, 11);
        }
    }
    return result;
}

void printArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] array = getArray(m, n);
printArray(array);

int[,] getSqrtArray(int[,] arr1)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                arr1[i, j] = arr1[i, j] * arr1[i, j];
            }
        }
    }
    return arr1;
}

int[,] newArray = getSqrtArray(array);

Console.WriteLine();

printArray(newArray);