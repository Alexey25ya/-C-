// Напишите программу, которая выводит случайное 
// число из отрезка [10, 99] и показывает наибольшую цифру числа
int showNumber()
{
   int num = new Random().Next(10,99);
   int first = num/10;
   int second = num%10;

   Console.Write(num+"->");
   if(first>second)
   {
    return first;
   }
   else{return second;}
};
 Console.WriteLine(showNumber());
