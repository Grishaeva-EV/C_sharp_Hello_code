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

/// <summary>
/// Thrown when input value is Integer and greater than 0
/// </summary>
/// <returns>
/// returns the entered integer
/// </returns>
int Read()
{
    bool result = int.TryParse(Console.ReadLine(), out int inputNumber);
    while( result != true || inputNumber < 2)
    {
        Console.WriteLine("Ошибка ввода: введено не целое число, больше 1. Попробуйте повторить");
        result = int.TryParse(Console.ReadLine(), out inputNumber);
    }
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
            Console.Write(integerArray[i, k] + "  ");
        }
        System.Console.WriteLine();
    }

    return integerArray;
}

System.Console.WriteLine("Введите количество строк таблицы (целое число больше 1)");
int rowCount = Read();
System.Console.WriteLine("Введите количество столбцов таблицы (целое число больше 1)");
int columnCount = Read();

int[,] array = FillRandomIntegerArray(rowCount, columnCount);