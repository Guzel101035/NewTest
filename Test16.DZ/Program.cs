// 21 Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
//14212-> нет
//12832-> да
//23432-> да


using static System.Console;
Clear();
WriteLine("Ведите пятизначное число:");
 string?number = Console.ReadLine();

void CheckingNumber(string number) 
{
    if(number[0]==number[4] || number[1]==number[3])
    {
    Console.WriteLine($"Ваше число: {number} ДА палиндром.");
    }
    else Console.WriteLine($"Ваше число: {number} НЕТ не палиндром.");
 }
    if(number!.Length == 5 )
    {
        CheckingNumber(number);
    }
    else Console.WriteLine($"Введите правильное число");
