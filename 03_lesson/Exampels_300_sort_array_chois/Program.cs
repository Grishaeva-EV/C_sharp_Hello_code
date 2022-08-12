// Exampels_300_sort_array_chois: sort min-max

// 1. Найти позицию минимального элемента в неотсортированной части массива
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции
// 3. Повторять пока есть не отсортированные элементы

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int ind = i + 1; ind < array.Length; ind++)
        {
            if (array[ind] < array[minPosition]) {minPosition = ind;}
        }

        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}

int[] arr = {1, 5, 8, 3, 5, 8, 6, 7, 2};

PrintArray(arr);

SelectionSort(arr);
PrintArray(arr);