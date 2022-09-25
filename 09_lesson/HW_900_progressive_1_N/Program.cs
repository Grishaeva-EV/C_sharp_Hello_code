// HW_900_progressive_1_N: input integer; output arithmetic progression [1 .. N]
// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"



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

int F(int i)
{
    if (i == 1) 
    {
        System.Console.Write("1");
        return i;
    }
    i = F(i-1)+1;
    System.Console.Write("  " + i);
    return i;
}

System.Console.Write("Введите натуральное число больше 1: ");
int n = CheckConsoleInput();
System.Console.WriteLine();

F(n);