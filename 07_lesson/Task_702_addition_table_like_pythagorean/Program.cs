// Task_702_addition_table_like_pythagorean
// Declare and initialize an 2 rang array which elements are summ of their indexes
// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: 
// Aₘₙ = m+n. Выведите полученный массив на экран.

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
/// Declare and initialize an 2 rang array which elements are summ of their indexes
/// </summary>
/// <param name="inputRowCount">
/// given number of rows
/// </param>
/// <param name="inputColumnCount">
/// given number of columns
/// </param>
/// <returns>
/// array of random integer numbers
/// </returns>
int[,] AdditionTableLikePythagorean(int inputRowCount, int inputColumnCount)
{
    int[,] additionTable = new int[inputRowCount, inputColumnCount];

    for(int i=0; i < inputRowCount; i++)
    {
        for(int k=0; k < inputColumnCount; k++)
        {
            additionTable[i, k] = i + k;            
        }
    }

    return additionTable;
}

/// <summary>
/// Write in  Console 2 rang array
/// </summary>
/// <param name="inputArray">
/// given 2 rang array
/// </param>
void WriteArray(int[,] inputArray)
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

int[,] array = AdditionTableLikePythagorean(rowCount, columnCount);

System.Console.WriteLine();
System.Console.WriteLine($"Массив {rowCount} * {columnCount}, каждый элемент которого равен сумме его индексов:");
WriteArray(array);
