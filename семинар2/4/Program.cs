// Напишите программу, 
//которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.

Console.WriteLine ("введите число");
int num = Convert.ToInt32(Console.ReadLine());
string showNum()
{
 if (num%7==0 && num%23==0)
  {
    return "кратно";
  }
 else 
  {
    return "не кратно";
  }
}
Console.WriteLine (showNum());

