// Task000_square_or_not: input two numbers, 
//compare first and and square of second
//output is first square of second or not

Console.WriteLine("Введите число A");
Console.Write("A = ");
double.TryParse(Console.ReadLine(), out double numberA);

Console.WriteLine("Введите число B");
Console.Write("A = ");
double.TryParse(Console.ReadLine(), out double numberB);

if(numberA == numberB * numberB)
{
    Console.WriteLine("Число A является квадратом числа B");
}
else
{
    Console.WriteLine("Число A является НЕ квадратом числа B");
}
