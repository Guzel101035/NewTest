// 21 Напишите программу , которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.

using static System.Console;
Clear();
Console.WriteLine("Ведите координаты первой точки:");
int x1 = Convert.ToInt32(ReadLine());
int y1 = Convert.ToInt32(ReadLine());
int z1 = Convert.ToInt32(ReadLine());

WriteLine("Введите координаты второй точки:");
int x2 = Convert.ToInt32(ReadLine());
int y2 = Convert.ToInt32(ReadLine());
int z2 = Convert.ToInt32(ReadLine());

double distance = Math.Sqrt((x2-x1)*(x2-x1)+ (y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
Write($"Расстояние между точками равно {distance:f2}");