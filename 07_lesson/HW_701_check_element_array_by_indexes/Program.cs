// HW_701_check_element_array_by_indexes
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

/// <summary>
/// Check Element By Indexes
/// in 2 rang array
/// And Write it in Console or notice "array has no element whith given indexes"
/// </summary>
/// <param name="InArray">
/// given 2 rang array
/// </param>
/// <param name="index1">
/// given index of 1th rank in given 2 rang array
/// </param>
/// <param name="index2">
/// given index of 2th rank in given 2 rang array
/// </param>
void CheckAndShowElementByIndexes(int[,] InArray ,int index1, int index2)
{
    if(index1 > InArray.GetUpperBound(0) || index2 > InArray.GetUpperBound(1) )
    {
        System.Console.WriteLine($"Элемент массива с индексами {index1} и {index2} нет в заданном массиве");
        System.Console.WriteLine();
    }
    else
    {
        System.Console.WriteLine($"Элемент массива с индексами {index1} и {index2}  равен ");
        System.Console.WriteLine($"array[{index1}, {index2}] = {InArray[index1, index2]}");
        System.Console.WriteLine();
    };
}



int[,] array = RandomIntegerArray();

System.Console.WriteLine();
System.Console.WriteLine($"Массив {array.GetUpperBound(0)+1} * {array.GetUpperBound(1)+1}, заполненный случайными целыми числами:");
WriteArray(array);

System.Console.WriteLine();
System.Console.WriteLine("Введите номер строки элемента (целое число от 0):");
int m = CheckConsoleInput();

System.Console.WriteLine();
System.Console.WriteLine("Введите номер столбца элемента (целое число от 0):");
int n = CheckConsoleInput();

CheckAndShowElementByIndexes(array, m, n);

