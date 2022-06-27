// Напишите программу, которая принимает 
//на вход два числа и проверяет, является ли 
//одно число квадратом другого.

Console.WriteLine ("введите два числа");
int firstNum = Convert.ToInt32(Console.ReadLine());
int secondNum = Convert.ToInt32(Console.ReadLine());
string square (int num1, int num2)
{
 if (num1*num1==num2)
  {
    return "второе число - квадрат первого";
  }
 else if (num2*num2==num1)
  {
    return "первое число - квадрат второго";
  }
 else 
 {
    return "ни одно не является квадратом другого";
 } 
}
Console.WriteLine (square(firstNum, secondNum));
