// 302Task_square_of _number
// Задача 22: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.

System.Console.WriteLine(); //для красоты
System.Console.WriteLine("============================="); //для красоты
System.Console.WriteLine(); //для красоты

int x = new Random().Next(2, 10);
System.Console.WriteLine("x = " + x);
System.Console.WriteLine();
System.Console.WriteLine($"Квадраты натуральных чисел от 1 до {x}: "); //интерполяция строк с помощью значка доллара
int i = 1;

while (i <= x)
{
    System.Console.Write(i * i + "; ");
    i++;
}

System.Console.WriteLine(); //для красоты
System.Console.WriteLine(); //для красоты
System.Console.WriteLine("============================="); //для красоты
System.Console.WriteLine(); //для красоты