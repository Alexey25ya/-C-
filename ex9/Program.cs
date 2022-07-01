void Farray(int[] collect)
{
    int length = collect.Length;
    int i=0;
    while(i<length)
    {
        collect[i]=new Random().Next(1,100);
        i++;
    }
}
void Parray(int[] col)
{
    int l=col.Length;
    int i1=0;
    while (i1<l)
    {
        Console.WriteLine(col[i1]);
        i1++;
    }
}
int[] array = new int[10];
Farray(array);
Parray(array);