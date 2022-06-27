// Напишите программу, которая выводит 
// случайное трёхзначное число и удаляет вторую цифру этого числа.
int showNumber()
{
   int num = new Random().Next(100,999);
   int first = num/100;
   int second = num%10;
   Console.Write(num+"->");
   int a = first*10+second;
   return (a);
   };
   Console.WriteLine(showNumber());