// 18 Выводим номер четверти по данным x y.
using static System.Console;
Clear();
Write("Ведите число x:");
int x = Convert.ToInt32(ReadLine());
Write("Ведите число y:");
int y = Convert.ToInt32(ReadLine());
if(x > 0 && y > 0)
{
    Write("1");
}
if(x > 0 && y < 0)
{
    Write("2");
}
if(x < 0 && y < 0)
{
    Write("3");
}
if(x < 0 && y > 0)
{
    Write("4");