// Task_701_square_of_even_array_elements
// Find squares of even idex elements in the given array
// and replace them by squares of them
// Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

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
/// Declare and initialize an 2 rang array of random integer numbers
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
int[,] FillRandomIntegerArray(int inputRowCount, int inputColumnCount)
{
    int[,] integerArray = new int[inputRowCount, inputColumnCount];

    for(int i=0; i < inputRowCount; i++)
    {
        for(int k=0; k < inputColumnCount; k++)
        {
            integerArray[i, k] = new Random().Next(2, 100);            
        }
    }

    return integerArray;
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


/// <summary>
/// Find squares of even idex elements in the given array
/// and replace them by squares of them
/// </summary>
/// <param name="givenArray">
/// given 2 rang array
/// </param>
void SquareEvenArrayElements(int[,] givenArray)
// int[,] SquareEvenArrayElements(int[,] givenArray)
{
    System.Console.WriteLine();
    for(int i=1; i < (1 + givenArray.GetUpperBound(0)); i+=2)
    {
        for(int k=1; k < (1 + givenArray.GetUpperBound(1)); k+=2)
        {
            givenArray[i, k] = givenArray[i, k] * givenArray[i, k];
        }
    }

//    return givenArray; //если нужно будет возвращать в другой массив изменения
// то пишем функцию, а не процедуру
}



System.Console.WriteLine("Введите количество строк таблицы (целое число больше 1)");
int rowCount = CheckConsoleInput();
System.Console.WriteLine("Введите количество столбцов таблицы (целое число больше 1)");
int columnCount = CheckConsoleInput();

int[,] array = FillRandomIntegerArray(rowCount, columnCount);

System.Console.WriteLine();
System.Console.WriteLine($"Массив {rowCount} * {columnCount}, заполненный случайными целыми числами:");
WriteArray(array);

SquareEvenArrayElements(array);

System.Console.WriteLine();
System.Console.WriteLine("Элементы с чётными индексами обоих измерений заменены квадраты этих элементов:");
WriteArray(array);

