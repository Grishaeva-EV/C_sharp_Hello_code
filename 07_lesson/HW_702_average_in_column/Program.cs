// HW_702_average_in_column
// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

/// <summary>
/// Thrown when input value is Integer and greater than 0
/// </summary>
/// <returns>
/// returns the entered integer
/// </returns>
int CheckConsoleInput()
{
    bool result = int.TryParse(Console.ReadLine(), out int inputNumber);
    
    if(result = true & inputNumber > -1){return inputNumber;};

    Console.WriteLine("Ошибка ввода: индекс элемента может быть только целым число от 0 и больше. Попробуйте повторить");
    inputNumber = CheckConsoleInput();

    return inputNumber;
}

/// <summary>
/// Declare and initialize an 2 rang array of random integer numbers
/// </summary>
int[,] RandomIntegerArray()
{
    int inputRowCount =new Random().Next(2, 10);
    int inputColumnCount =new Random().Next(2, 10);
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


void AverageInColumn(int[,] inArray)
{
    int sumColumnElements;
    for (int i = 0; i < 1 + inArray.GetUpperBound(1); i++)
    {
        sumColumnElements = 0;
        for (int k = 0; k < 1 + inArray.GetUpperBound(0); k++)
        {
           sumColumnElements += inArray[k,i];
        }
        System.Console.Write($"{sumColumnElements/(1 + inArray.GetUpperBound(0))} ");
    };
    System.Console.WriteLine();
}

int[,] array = RandomIntegerArray();

System.Console.WriteLine();
System.Console.WriteLine($"Массив {array.GetUpperBound(0)+1} * {array.GetUpperBound(1)+1}, заполненный случайными целыми числами:");
WriteArray(array);

System.Console.WriteLine("Среднее арифмитическое каждого столбца массива:");
AverageInColumn(array);