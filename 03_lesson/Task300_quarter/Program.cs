// Task300_quarter
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.



void DisplayMeasurements(int a, int b) //оператором если и подачей координат априори без нуля
{    
        if (a > 0 & b > 0)
            {
                Console.WriteLine($"x-coordinate is {a}, y-coordinate is {b}. It is quadrant I"); //о, как! можно интерполировать строки
            }
        else if (a < 0 & b > 0)
            {
                Console.WriteLine($"x-coordinate is {a}, y-coordinate is {b}. It is quadrant II");
            }   
        else if  (a < 0 & b < 0)
            {
                Console.WriteLine($"x-coordinate is {a}, y-coordinate is {b}. It is quadrant III");
            }
        else if  (a > 0 & b < 0)
            {
                Console.WriteLine($"x-coordinate is {a}, y-coordinate is {b}. It is quadrant IV");
            }             
        else
            {
                Console.WriteLine("The point lies on the axis.");
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

int x=0; //начальные значения 0, чтобы цикл хотя бы раз сработал
int y=0;
while(x == 0 || y == 0) //задаем случайные координаты, не лежащие на осях
{
    //x = new Random().Next(-1, 1);
    //y = new Random().Next(-1, 1);
    x = new Random().Next(-1000000000, 1000000000);
    y = new Random().Next(-1000000000, 1000000000);
    System.Console.WriteLine("x = " + x + "y = " + y);
}

System.Console.WriteLine("x = " + x + "; y = " + y);
DisplayMeasurements(x, y);  // Output: The point lies on the axis

