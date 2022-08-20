// задача с for.
using static System.Console;
Clear();
Write("Ведите число a:");
int a = Convert.ToInt32(ReadLine());
for(int i = 2; i < a; i+=2)
{
    Write($"{i} ");
}
