// HW_601_POUNT
// y = k1 * x + b1; => x = (y - b1) / k1
// y = k2 * x + b2; => x = (y - b2) / k2
// В точке пересечения координаты x и y равны для этих прямых. Вычислим Х

// k1 * x + b1 = k2 * x + b2;
// x(k1 - k2) = b2 - b1;
// x = (b2 - b1) / (k1 - k2);

// вычислим y
// (y - b1) / k1 = (y - b2) / k2;
// y * k2 - b1 * k2 = y * k1 - b2 * k1;
// (k2 - k1) * y = b1 * k2 - b2 * k1;
// y = (b1 * k2 - b2 * k1) / (k2 - k1);

double read()
{
    bool result = double.TryParse(Console.ReadLine(), out double number);
    while(result != true)
    {
        Console.WriteLine("Вы ввели не число. Повторите попытку.");
        result = double.TryParse(Console.ReadLine(), out number);
    }  

    return number;
}

System.Console.WriteLine("Задайте прямые по угловому коэффициенту k и начальной ординате b");
System.Console.WriteLine(("свободному параметру"));
System.Console.WriteLine(("y = k * x + b"));
System.Console.WriteLine();

System.Console.WriteLine("Первая прямая");
System.Console.Write("угловой коэффициент k1 = ");
double k1 = read();
System.Console.Write("начальная ордината b1 = ");
double b1 = read();
System.Console.WriteLine();
System.Console.WriteLine("Уравнение первой прямой");
System.Console.WriteLine($"y = {k1}x + {b1}");
System.Console.WriteLine();

System.Console.WriteLine("Вторая прямая");
System.Console.Write("угловой коэффициент k2 = ");
double k2 = read();
System.Console.Write("начальная ордината b2 = ");
double b2 = read();
System.Console.WriteLine();
System.Console.WriteLine("Уравнение второй прямой");
System.Console.WriteLine($"y = {k2}x + {b2}");
System.Console.WriteLine();

double x = (b2 - b1) / (k1 - k2);
double y = (b1 * k2 - b2 * k1) / (k2 - k1);

System.Console.WriteLine("Точка пересечения заданных прямых ");
System.Console.WriteLine($"Точка пересечения заданных прямых ({x}; {y})");
System.Console.WriteLine();