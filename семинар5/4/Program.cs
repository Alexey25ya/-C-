// // Задача 35: Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] getArray(int n)
{
int[] arr = new int[n];
for (int i = 0; i < arr.Length; i++)
{
arr[i] = new Random().Next(0, 1200);
}
return arr;
}

int[] array1 = getArray(123);

int getResult(int[] array2)
{
int count = 0;
for (int i = 0; i < array2.Length; i++)
{
if (array2[i] <100 & array2[i] > 9)
{
count ++;
}
}
return count;
}

Console.WriteLine ("Числа от 10 до 99 встречаются " + getResult(array1) + " раз");
