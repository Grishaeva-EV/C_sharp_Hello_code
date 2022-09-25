// HW_903_summ_progressive_M_N_positive
// input integers M and N; 
// output summ of arithmetic progression [M .. N]
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



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
/// adds all integers>0 from big to small
/// output in console "не существует"
/// </summary>
/// <param name="big">
/// input integer
/// </param>
/// <param name="small">
/// input integer
/// big >= small
/// </param>
/// <returns>
/// returns summ of all integers>0 from big to small
/// or returns 0
/// </returns>
int SummAllPositiveIntegersBetweenTwoIntegers(int big, int small)
{
    if (big < 1 && small < 1)
    {
        System.Console.WriteLine($"не существует");

        return 0;
    }
        
    if (big == small || 1 == big) 
    {
        return big;
    }

    big = big + SummAllPositiveIntegersBetweenTwoIntegers(big-1, small);
    
    return big;    
}


System.Console.Write("Введите целое число M = ");
int m = CheckConsoleInput();
System.Console.WriteLine();

System.Console.Write("Введите целое число N = ");
int n = CheckConsoleInput();
System.Console.WriteLine();



System.Console.Write($"Между числами {n} и {m} сумма натуральных чисел "); 
if (m > n)
{
    System.Console.WriteLine(SummAllPositiveIntegersBetweenTwoIntegers(m, n));        
}
else
{
    System.Console.WriteLine(SummAllPositiveIntegersBetweenTwoIntegers(n, m));    
}



