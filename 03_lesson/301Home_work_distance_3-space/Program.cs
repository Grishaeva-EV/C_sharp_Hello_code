// 301Home_work_distance_3-space
// Distance between two points in a three dimension x, y and z coordinate system
// d = ((x2 - x1)^2 + (y2 - y1)^2 + (z2 - z1)^2)^1/2

void WonderfulFrame() //для красоты
{
    System.Console.WriteLine(); 
    System.Console.WriteLine("=============================");
    System.Console.WriteLine(); 
}

double read() //проверяем, что там введено, ддосим, пока не получим число
{      
    bool result = double.TryParse(Console.ReadLine(), out double A);
    if (result != true) //проверка типа введенного значения
    {
        while(result != true)
        {
            Console.WriteLine("Вы ввели не число. Введите число");
            result = double.TryParse(Console.ReadLine(), out A);
        }    
    }
    return(A);
}

double[] get_coordonate(int serial) //тк кортеж я не освоила, то запихну координаты в трехмерный массив
{
    double[] arr = new double[3];
    System.Console.WriteLine($"Задайте координаты {serial}-й точки в прямоугольной системе координат в пространстве");
    System.Console.Write($"x{serial} = ");
    arr[0] = read();
    System.Console.Write($"y{serial} = ");
    arr[1] = read();
    System.Console.Write($"z{serial} = ");
    arr[2] = read();
    PrintArrayFor(arr, serial);
    return arr;
}

void PrintArrayFor(double[] col, int ser) //выводим на печать массив с помощью цикла со счетчиком
{
    System.Console.Write($"Координаты {ser}-й точки (");
    for (int i = 0; i < col.Length; i++) 
        {
            System.Console.Write(col[i]); 
            if(i != col.Length-1) {System.Console.Write("; "); }
        }
    System.Console.WriteLine(")");    
}


//тело программы
WonderfulFrame();

double[] point1 = get_coordonate(1);
double[] point2 = get_coordonate(2);

double Distance = 0;
for (int i = 0; i < 3; i++)
{
    Distance = Distance + (point1[i] - point2[i]) * (point1[i] - point2[i]);
}
Distance = Math.Sqrt(Distance);
System.Console.WriteLine();
System.Console.WriteLine("Расстояние между заданными точками равно " + Distance);

WonderfulFrame();