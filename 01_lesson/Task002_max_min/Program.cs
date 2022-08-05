// Task002_max_min
// input two numbers 
// output max and min

Console.WriteLine("Введите число A");
Console.Write("A = ");
double.TryParse(Console.ReadLine(), out double numberA);

Console.WriteLine("Введите число B");
Console.Write("B = ");
double.TryParse(Console.ReadLine(), out double numberB);

if(numberA > numberB)
{
    Console.WriteLine("Число A больше числа B");
    Console.Write("max = ");
    Console.WriteLine(numberA);
    Console.Write("min = ");
    Console.WriteLine(numberB);

}
else
{
    if(numberA < numberB)
    {
        Console.WriteLine("Число A меньше числа B");
        Console.Write("max = ");
        Console.WriteLine(numberB);
        Console.Write("min = ");
        Console.WriteLine(numberA);
    }
    else
    {
        Console.WriteLine("Числа A и B равны. Максимум и минимум равны");
        Console.Write("max = min =");
        Console.WriteLine(numberB);
    }
}