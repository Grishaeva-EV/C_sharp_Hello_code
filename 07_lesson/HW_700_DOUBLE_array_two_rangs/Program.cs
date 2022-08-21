// HW_700_DOUBLE_array_two_rangs
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

/// <summary>
/// Thrown when input value is Integer and greater than 0
/// </summary>
/// <returns>
/// returns the entered integer
/// </returns>
int CheckConsoleInput()
{
    bool result = int.TryParse(Console.ReadLine(), out int inputNumber);
    
    if(result = true & inputNumber > 1){return inputNumber;};

    Console.WriteLine("Ошибка ввода: введено не целое число, больше 1. Попробуйте повторить");
    inputNumber = CheckConsoleInput();

    return inputNumber;
}


/// <summary>
/// Declare and initialize an 2 rang array of random DOUBLE numbers
/// </summary>
/// <param name="inputRowCount">
/// given number of rows
/// </param>
/// <param name="inputColumnCount">
/// given number of columns
/// </param>
/// <returns>
/// array of random double numbers
/// </returns>
double[,] FillRandomDoubleArray(int inputRowCount, int inputColumnCount)
{
    double[,] doubleArray = new double[inputRowCount, inputColumnCount];

    for(int i=0; i < inputRowCount; i++)
    {
        for(int k=0; k < inputColumnCount; k++)
        {
            doubleArray[i, k] = (new Random().NextDouble()) * (new Random().Next(-10000, 10000));            
        }
    }

    return doubleArray;
}

/// <summary>
/// Write in  Console 2 rang array
/// </summary>
/// <param name="inputArray">
/// given 2 rang array
/// </param>
void WriteArray(double[,] inputArray)
{
    System.Console.WriteLine();
    for(int i=0; i < (1 + inputArray.GetUpperBound(0)); i++)
    {
        for(int k=0; k < (1 + inputArray.GetUpperBound(1)); k++)
        {
            Console.Write(inputArray[i, k] + "  ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}


System.Console.WriteLine("Введите количество строк таблицы (целое число больше 1)");
int rowCount = CheckConsoleInput();
System.Console.WriteLine("Введите количество столбцов таблицы (целое число больше 1)");
int columnCount = CheckConsoleInput();

double[,] array = FillRandomDoubleArray(rowCount, columnCount);

System.Console.WriteLine();
System.Console.WriteLine($"Массив {rowCount} * {columnCount}, заполненный случайными вещественными числами:");
WriteArray(array);
