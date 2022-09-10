// HW_801_matrix_product
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц


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
/// Declare and initialize an 2D array of random integers
/// </summary>
int[,] RandomIntegerArray(int inputRowCount, int inputColumnCount)
{
    int[,] integerArray = new int[inputRowCount, inputColumnCount];

    for(int i=0; i < inputRowCount; i++)
    {
        for(int k=0; k < inputColumnCount; k++)
        {
            integerArray[i, k] = new Random().Next(-1000, 1000);            
        }
    }

    return integerArray;
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
/// calculate Two Matrix Product
/// or return array of 0 elements and write in console 
/// "Ошибка! Размеры матриц не совпадают!"
/// </summary>
/// <param name="inMatrix1">
/// given 2D array
/// </param>
/// <param name="inMatrix2">
/// given 2D array
/// </param>
int[,] TwoMatrixProduct(int[,] inMatrix1, int[,] inMatrix2)
{
    int[,] productOf2Matrix = new int[inMatrix1.GetUpperBound(0) + 1, inMatrix1.GetUpperBound(1) + 1];
    if(inMatrix1.GetUpperBound(0)!=inMatrix2.GetUpperBound(0) || inMatrix1.GetUpperBound(1)!=inMatrix2.GetUpperBound(1))
    {
        System.Console.WriteLine("Ошибка! Размеры матриц не совпадают!");
        return productOf2Matrix; //возвращаем нулевой массив
    };
    
    for (int i = 0; i < inMatrix1.GetUpperBound(0) + 1; i++)
    {
        for (int k = 0; k < inMatrix1.GetUpperBound(1) + 1; k++)
        {
            productOf2Matrix[i,k] = inMatrix1[i,k] * inMatrix2[i,k];
        }
    }
    return productOf2Matrix;
}


System.Console.WriteLine("Введите количество строк таблицы (целое число больше 1): ");
int rowCount = CheckConsoleInput();
System.Console.WriteLine("Введите количество столбцов таблицы (целое число больше 1): ");
int columnCount = CheckConsoleInput();

int[,] matrix1 = RandomIntegerArray(rowCount, columnCount);
System.Console.WriteLine("Матрица 1:");
WriteArray(matrix1);

int[,] matrix2 = RandomIntegerArray(rowCount, columnCount);
System.Console.WriteLine("Матрица 2:");
WriteArray(matrix2);

int[,] matrix3 = TwoMatrixProduct(matrix1, matrix2);
System.Console.WriteLine("Произведение Матрицы 1 и Матрицы 2:");
WriteArray(matrix3);