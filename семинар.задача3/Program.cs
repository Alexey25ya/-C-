Console.WriteLine("Введите положительное число");
int num = Convert.ToInt32(Console.ReadLine());

int numnegative = num * -1;

while (numnegative <= num)
{
    Console.WriteLine(numnegative);
    numnegative ++;
}