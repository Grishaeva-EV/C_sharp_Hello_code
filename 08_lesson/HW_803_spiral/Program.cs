// HW_803_spiral
// Задача 62. Заполните спирально массив 4 на 4


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

    Console.WriteLine("Ошибка ввода: введено не целое число больше 1. Попробуйте повторить");
    inputNumber = CheckConsoleInput();

    return inputNumber;
}

/// <summary>
/// Write in Console 2D array
/// </summary>
/// <param name="inputArray">
/// given 2D array
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
/// Fill 2D array with numbers in a spiral
/// </summary>
/// <param name="size">
/// rank0 = rank1 = size 2D array
/// </param>
int[,] FillSpiralMatrix(int size)
{
    int half = size / 2;
    int amountElements = size * size;
    int[,] spiralMatrix = new int[size, size];
    int row = 0;
    int column = 0;
    int count = 0;
    while(count < amountElements)
    {
        if
        // 1 quarter (upper)
        (
            (column < size - row - 1) && (column > row - 2) 
            && (row < half + 1 ) && (row > -1)
        )
        {
            spiralMatrix[row, column] = count + 1;
            System.Console.WriteLine($"count = {count}");
            System.Console.WriteLine($"spiralMatrix[{row}, {column}] = {spiralMatrix[row, column]}");
            System.Console.WriteLine("1 quarter");
            System.Console.WriteLine();
            column++;
        }    
        else if
        // 2 quarter (right)
        (
            (column < size) && (column >= half)  
            && (row < column) && (row > -1)
        )
        {
            spiralMatrix[row, column] = count + 1;
            System.Console.WriteLine($"count = {count}");
            System.Console.WriteLine($"spiralMatrix[{row}, {column}] = {spiralMatrix[row, column]}");
            System.Console.WriteLine("2 quarter");
            System.Console.WriteLine();
            row++;
        }
        else if
        // 3 quarter (lower)
        (
            (column < size) && (column > size - row - 1)  
            && (row < size) && (row >= half)
        )
        {
            spiralMatrix[row, column] = count + 1;
            System.Console.WriteLine($"count = {count}");
            System.Console.WriteLine($"spiralMatrix[{row}, {column}] = {spiralMatrix[row, column]}");
            System.Console.WriteLine("3 quarter");
            System.Console.WriteLine();
            column--;
        }
        else if
        // 4 quarter (left)
        (
            (column < half) && (column > - 1)  
            && (row < size) && (row > column + 1)
        )
        {
            spiralMatrix[row, column] = count + 1;
            System.Console.WriteLine($"count = {count}");
            System.Console.WriteLine($"spiralMatrix[{row}, {column}] = {spiralMatrix[row, column]}");            
            System.Console.WriteLine("4 quarter");
            System.Console.WriteLine();
            row--;
        }        
        else
        {
            spiralMatrix[row, column] = count + 1;
            System.Console.WriteLine("исключение");
            System.Console.WriteLine($"count = {count}");
            System.Console.WriteLine($"spiralMatrix[{row}, {column}] = {spiralMatrix[row, column]}");
        }

        count++;
    }

    return spiralMatrix;
}


System.Console.Write("Введите размер двумерного массива с равными измерениями: ");
int sizeArray = CheckConsoleInput();

int[,] array = FillSpiralMatrix(sizeArray);
WriteArray(array);