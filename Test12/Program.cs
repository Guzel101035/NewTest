// Напишите программу , которая принимает на входе число N 
//и выдаёт таблицу квадратов чисел от 1 до N.

using static System.Console;
Clear();
WriteLine("Ведите число :");
int n = Convert.ToInt32(ReadLine());

int index = 1;
//int square = 0;
//int result = 0;

while(index <=n )
{
    Write(index*index + " ");
    index++;
}
WriteLine();
