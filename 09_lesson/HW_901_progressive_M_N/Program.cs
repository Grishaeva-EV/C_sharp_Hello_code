// HW_901_progressive_M_N: input integers M and N; 
// output arithmetic progression [M .. N]
// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"


/// <summary>
/// Thrown when input value is Integer and greater than 1
/// </summary>
/// <returns>
/// returns the entered integer
/// </returns>
int CheckConsoleInput()
{
    bool result = int.TryParse(Console.ReadLine(), out int inputNumber);
    
    while(result != true & inputNumber > 1)
    {
        Console.WriteLine("Ошибка ввода: введено не целое число больше 1. Попробуйте повторить.");
        result = int.TryParse(Console.ReadLine(), out inputNumber);
    }
    return inputNumber;
}

int F(int big, int small)
{
    if (big == small) 
    {
        System.Console.Write(big);
        return big;
    }
    big = F(big-1, small) + 1;
    System.Console.Write("  " + big);
    return big;
}

System.Console.Write("Введите M - натуральное число больше 1: ");
int m = CheckConsoleInput();
System.Console.WriteLine();

System.Console.Write("Введите N - натуральное число больше 1: ");
int n = CheckConsoleInput();
System.Console.WriteLine();

if (m > n)
{
    F(m, n);
}
else
{
    F(n, m);
}
