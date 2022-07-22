// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
/*1, 2, 3

4, 6, 1

2, 1, 6

1 встречается 3 раза

2 встречается 2 раз

3 встречается 1 раз

4 встречается 1 раз

6 встречается 2 раза
*/


int[,] getArray(int mLocal, int nLocal)
{
    int[,] result = new int[mLocal, nLocal];
    for (int i = 0; i < mLocal; i++)
    {
        for (int j = 0; j < nLocal; j++)
        {
            result[i, j] = new Random().Next(0, 10);
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
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] changeArray(int[,] array)
{
    int[] arrayLocal = new int[array.GetLength(0) * array.GetLength(1)];
    int index = 0;
    foreach (int number in array)
    {
        arrayLocal[index] = number;
        index++;
    }
    return arrayLocal;
}

void SortArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = i + 1; j < inArray.Length; j++)
        {
            if (inArray[i] > inArray[j])
            {
                int k = inArray[i];
                inArray[i] = inArray[j];
                inArray[j] = k;
            }
        }
    }
}

int rows = 3;
int columns = 3;
int[,] array1 = getArray(rows,columns);
printArray(array1);
int [] orderArray = changeArray(array1);
SortArray(orderArray);
Console.WriteLine();

foreach (int item in orderArray)
{
    Console.Write(item);
}