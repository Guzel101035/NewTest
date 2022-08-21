// 13. Напишите программу,которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
using static System.Console;
Clear();
Console.WriteLine("Введите число: ");
int number =Convert.ToInt32(ReadLine());

if(number < 99)
{
    Console.WriteLine("Третьей цифры нет");
}
 
if( number > 99 && number <1000)
{
   int number1 = number % 10;
   Console.WriteLine(number1);
}

   else
   
      while(number < 1000)
      {
         int number2 =  number / 10;
         int number3 = number2 % 10; 
         Write( number3);
      } 
Console.WriteLine();
   

   



