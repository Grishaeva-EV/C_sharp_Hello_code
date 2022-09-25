// HW_902_progressive_M_N_negative: input integers M and N; 
// output arithmetic progression [M .. N]
// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"



// так как я не нашла различий между задачами 64 и 65, кроме ошибки в примере
// я решила в этом решении выводить только натуральную часть (от 1 до ...) промежутка между целыми числами M и N
// поэтому они только целые, в т.ч. 0 и отрицательные


/// <summary>
/// Thrown when input value is Integer
/// </summary>
/// <returns>
/// returns the entered integer
/// </returns>
int CheckConsoleInput()
{
    bool result = int.TryParse(Console.ReadLine(), out int inputNumber);
    
    while(result != true)
    {
        Console.WriteLine("Ошибка ввода: введено не целое число. Попробуйте повторить.");
        result = int.TryParse(Console.ReadLine(), out inputNumber);
    }
    return inputNumber;
}

/// <summary>
/// output in console all integers>0 from big to small
/// </summary>
/// <param name="big">
/// input integer
/// </param>
/// <param name="small">
/// input integer
/// big >= small
/// </param>
/// <returns>
/// returns big
/// </returns>
int ProgressiveBetweenTwoIntegers(int big, int small)
{
    if (big < 1 && small < 1)
    {
        System.Console.Write($"Между числами {big} и {small} нет натуральных чисел");

        return big;
    }
        
    if (big == small || 1 == big) 
    {
        System.Console.Write(big);

        return big;
    }

    big = ProgressiveBetweenTwoIntegers(big-1, small) + 1;
    System.Console.Write("  " + big);

    return big;    
}


System.Console.Write("Введите целое число M = ");
int m = CheckConsoleInput();
System.Console.WriteLine();

System.Console.Write("Введите целое число N = ");
int n = CheckConsoleInput();
System.Console.WriteLine();

if (m > n)
{
    ProgressiveBetweenTwoIntegers(m, n);
}
else
{
    ProgressiveBetweenTwoIntegers(n, m);
}