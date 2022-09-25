// HW_905_Akerman
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29


/// <summary>
/// Thrown when input value is Integer and greater than 1
/// </summary>
/// <returns>
/// returns the entered integer
/// </returns>
int CheckConsoleInput()
{
    bool result = int.TryParse(Console.ReadLine(), out int inputNumber);
    
    while(result != true & inputNumber > -1)
    {
        Console.WriteLine("Ошибка ввода: введено не целое число от 0 и больше. Попробуйте повторить.");
        result = int.TryParse(Console.ReadLine(), out inputNumber);
    }
    return inputNumber;
}


int Ackermann(int numberM, int numberN)
{
    if(0 == numberM)
    {
        return numberN + 1;
    }

    if(numberM != 0 && 0 == numberN)
    {
        return Ackermann(numberM - 1, 1);
    }

    if(numberM > 0 && numberN > 0)
    {
        return Ackermann(numberM - 1, Ackermann(numberM, numberN - 1));
    }

    return Ackermann(numberM, numberN);
}


System.Console.WriteLine();
System.Console.Write("Введите целое неотрицательное число M: ");
int m = CheckConsoleInput();
System.Console.Write("Введите целое неотрицательное число N: ");
int n = CheckConsoleInput();

System.Console.WriteLine();
System.Console.WriteLine($"Функция Аккермана для неотрицательных чисел {m} и {n}):");
System.Console.WriteLine($"A({m}, {n}) = {Ackermann(m, n)}");
System.Console.WriteLine();