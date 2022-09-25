// HW_904_summ_of_number_digit
// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9



/// <summary>
/// Thrown when input value is Integer and greater than 1
/// </summary>
/// <returns>
/// returns the entered integer
/// </returns>
int CheckConsoleInput()
{
    bool result = int.TryParse(Console.ReadLine(), out int inputNumber);
    
    while(result != true & inputNumber > 0)
    {
        Console.WriteLine("Ошибка ввода: введено не натуральное число. Попробуйте повторить.");
        result = int.TryParse(Console.ReadLine(), out inputNumber);
    }
    return inputNumber;
}


/// <summary>
/// takes a number and adds it's digits
/// </summary>
/// <param name="number">
/// input integer > 0
/// </param>
/// <returns>
/// returns summ of number digits
/// </returns>
int SummOfNumberDigit(int number)
{
    if (number / 10 < 1)
    {
        return number;
    }
        
    number = number % 10 + SummOfNumberDigit(number / 10);
    
    return number;
}

System.Console.WriteLine();
System.Console.WriteLine();
System.Console.Write("Введите натуральное число: ");
int n = CheckConsoleInput();
System.Console.WriteLine();

System.Console.WriteLine("Сумма его цифр = " + SummOfNumberDigit(n));
System.Console.WriteLine();
System.Console.WriteLine();
