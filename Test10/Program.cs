// 18 Вводим номер четверти выводим данным x y.
using static System.Console;
Clear();
Write("Ведите число a:");
int a = Convert.ToInt32(ReadLine());

switch(a)
{
    case 1:
    {
          Write("x > 0 && y > 0");
          break;
    }
    case 2:
    {
          Write("x > 0 && y < 0");
          break;
    }
    case 3:
    {
          Write("x < 0 && y < 0");    
          break;
    }
    case 4:
    {
           Write("x < 0 && y > 0");
           break;
    }
    default:
    {
           Write("Нет такой четверти"); 
           break; 
    }
}
    
