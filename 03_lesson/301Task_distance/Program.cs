// Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними на координатной плоскости

double x1 = new Random().Next(-1000, 1000);
double y1 = new Random().Next(-1000, 1000);
System.Console.WriteLine("x1 = " + x1 + "; y1 = " + y1);

double x2 = new Random().Next(-1000, 1000);
double y2 = new Random().Next(-1000, 1000);
System.Console.WriteLine("x2 = " + x2 + "; y2 = " + y2);

double distance = Math.Sqrt ((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
System.Console.WriteLine("Расстояние между заданными точками координатной плоскости равно " + distance);

