// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// варианты задания двумерного массива
//int[,] nums1;
int[,] nums2 = new int[3, 4];
int[,] nums3 = new int[3, 4] { {1, 4, 8, 19}, {5, -2, 33, -2}, {77, 3, 8, 1} };
int[,] nums4 = new int[,] { {1, 4, 8, 19}, {5, -2, 33, -2}, {77, 3, 8, 1} };;
int[,] nums5 = new [,]{ {1, 4, 8, 19}, {5, -2, 33, -2}, {77, 3, 8, 1} };
int[,] nums6 = { {1, 4, 8, 19}, {5, -2, 33, -2}, {77, 3, 8, 1} };

// из задачи следует, что m и n надо запросить у пользователя
// но заполнить массив случайными числами
// очевидно, что измерение массива - натуральное число
// если одно из измерений равно 1, мы получаем одномерный массив

// раньше ввод с консоли проверяли циклом, теперь организуем проверку с помощью рекурсии

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
            integerArray[i, k] = new Random().Next();            
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


System.Console.WriteLine("Введите количество строк таблицы (целое число больше 1)");
int rowCount = CheckConsoleInput();
System.Console.WriteLine("Введите количество столбцов таблицы (целое число больше 1)");
int columnCount = CheckConsoleInput();

int[,] array = FillRandomIntegerArray(rowCount, columnCount);

System.Console.WriteLine();
System.Console.WriteLine($"Массив {rowCount} * {columnCount}, заполненный случайными целыми числами:");
WriteArray(array);
