// HW_802_min_sum_row_elements_2D_array
// Найти строку с наименьшей суммой элементов двумерного массива

/// <summary>
/// Declare and initialize an 2D array of random integers
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
/// Find Index Of Row With Min Sum Elements
/// in 2D array
/// Write in Console Index Of Row With Min Sum Elements and this min sum elements
/// return Index Of Row With Min Sum Elements
/// </summary>
int RowIndexWithMinSumElements(int[,] arrayRowMinSum)
{
    int minRowIndex = 0;
    int minRowSum = 0, rowSum;
    for (int i = 0; i < 1 + arrayRowMinSum.GetUpperBound(0); i++)
    {
        rowSum = 0;
        for (int k = 0; k < 1 + arrayRowMinSum.GetUpperBound(1); k++)
        {
            rowSum += arrayRowMinSum[i,k];
        }
        if(i == 0){minRowSum = rowSum;}
         
        if(rowSum < minRowSum)
        {
            minRowSum = rowSum;
            minRowIndex = i;
        }        
    }
    System.Console.WriteLine("индекс (от 0) строки с минимальной суммой элементов: " + minRowIndex);
    System.Console.WriteLine("минимальная сумма элементов строки: " + minRowSum); //два значения метод не возвращает
    //будем выводить индекс строки с мин суммой элементов и саму эту сумму

    return minRowIndex; //если будем дальше использовать в программе
}



int[,] array = RandomIntegerArray();

System.Console.WriteLine();
System.Console.WriteLine($"Массив {array.GetUpperBound(0)+1} * {array.GetUpperBound(1)+1}, заполненный случайными целыми числами:");
WriteArray(array);

int indexRow = RowIndexWithMinSumElements(array); //если нужно именно значение индекса строки для дальнейших расчетов
System.Console.WriteLine(indexRow); //проверяем себя

