// Task_601_valid_sides_for_triangle
// Check whether triangle is valid or not if sides are given
// Везет же, когда пытаешься в английский, а тебе твою ж задачу сразу полным переводом на тематическом сайте

int A = new Random().Next(1, 5); // для повышения вероятности равенства суммы двух чисел третьему, 
int B = new Random().Next(1, 5); // уменьшим диапазон случайных значений
int C = new Random().Next(1, 10);


// int A = 2; // тесты
// int B = 3; 
// int C = 5;

System.Console.WriteLine();
System.Console.WriteLine("Даны числа:");
System.Console.WriteLine("A = " + A);
System.Console.WriteLine("B = " + B);
System.Console.WriteLine("C = " + C);
System.Console.WriteLine();

if (A >= B + C || B >= C + A || C >= A + B) {System.Console.WriteLine("Треугольник невозможен");}
else {System.Console.WriteLine("Условие существования треугольника выполняется");}
System.Console.WriteLine();