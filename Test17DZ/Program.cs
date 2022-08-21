// 13. Напишите программу,которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
using static System.Console;
Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(ReadLine());

int number1 = number / 100;
if( number1 < 1)
{
    Console.WriteLine("Третьей цифры нет");
}
if( number1 > 1 && number1 <1000)
{
   int number2 = number1 % 10;
   Console.WriteLine(number2);
}
else
   while(number1 < 1000)
{
   int number3 = number / 10;
   WriteLine(number3);
}


