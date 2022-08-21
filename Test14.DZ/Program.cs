// Напишите программу , которая принимает на входе число(N) 
//и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1,8,27
// 5 -> 1,8,27,64,125

using static System.Console;
Clear();
WriteLine("Ведите число :");
int n = Convert.ToInt32(ReadLine());

int index = 1;
//int square = 0;
//int result = 0;

while(index <=n )
{
    Write(index*index*index + " ");
    index++;
}
WriteLine();

