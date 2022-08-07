// Task300_quarter with switch
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

void DisplayMeasurements(int a, int b)
{
    switch ((a, b)) //поиграем со свичом
    {
        case (> 0, > 0):
            Console.WriteLine($"x-coordinate is {a}, y-coordinate is {b}. It is quadrant I"); //о, как! можно интерполировать строки
            break;

        case (< 0, > 0):
            Console.WriteLine($"x-coordinate is {a}, y-coordinate is {b}. It is quadrant II"); 
            break;    
        case (< 0, < 0):
            Console.WriteLine($"x-coordinate is {a}, y-coordinate is {b}. It is quadrant III"); 
            break;

        case (> 0, < 0):
            Console.WriteLine($"x-coordinate is {a}, y-coordinate is {b}. It is quadrant IV"); 
            break; 
        default:
            Console.WriteLine("The point lies on the axis.");
            break;
    }
}

//тесты
Console.WriteLine("========Test=========");
DisplayMeasurements(3, 4);  // Output: quadrant I
DisplayMeasurements(-5, 5);  // Output: quadrant II
DisplayMeasurements(-3, -4);  // Output: quadrant III
DisplayMeasurements(3, -4);  // Output: quadrant IV
DisplayMeasurements(0, -4);  // Output: The point lies on the axis
DisplayMeasurements(0, 4);  // Output: The point lies on the axis
DisplayMeasurements(5, 0);  // Output: The point lies on the axis
DisplayMeasurements(-5, 0);  // Output: The point lies on the axis
DisplayMeasurements(0, 0);  // Output: The point lies on the axis
Console.WriteLine("========End Of Test=========");
System.Console.WriteLine();

//отправим случайные координаты без проверки на принадлежность оси
int x = new Random().Next(-1000000000, 1000000000);
int y = new Random().Next(-1000000000, 1000000000);
System.Console.WriteLine("x = " + x + "; y = " + y);
DisplayMeasurements(x, y);  // Output: The point lies on the axis

