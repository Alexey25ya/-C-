// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("vvedite nomer chetverti");
int n1 = Convert.ToInt32(Console.ReadLine());
string Func(int n)
{
    switch (n)

    {
        case 1:
            {
                return "x>0,y>0";
                break;
            }
        case 2:
            {
                return "x<0,y>0";
                break;
            }
        case 3:
            {
                return "x<0,y<0";
                break;
            }
        case 4:
            {
                return "x>0,y<0";
                break;
            }
        default:
            {

                {
                    return "err";
                    break;

                }
            }
    }
}
Console.WriteLine(Func(n1));
