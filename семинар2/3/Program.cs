// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе 
//число  кратным первому. Если второе число не кратно числу 
//первому, то программа выводит остаток от деления.

Console.WriteLine ("введите два числа");
int firstNum = Convert.ToInt32(Console.ReadLine());
int secondNum = Convert.ToInt32(Console.ReadLine());
string showNum (int num1, int num2)
{
 if (num2%num1==0)
  {
    return "второе кратно первому";
  }
 else 
  {
    return ("остаток равен "+num2%num1);
  }
}
Console.WriteLine (showNum(firstNum, secondNum));


