// HW_600_count_of_positive
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Read() //проверка ввода на integer
{
    bool result = int.TryParse(Console.ReadLine(), out int A);

    while(result != true)
    {
        Console.WriteLine("Вы ввели не целое число. Повторите попытку.");
        result = int.TryParse(Console.ReadLine(), out A);
    }    
    
    return(A);
}


int[] FillArrayByUser() //заполнение пользователем
{
    System.Console.WriteLine("Введите количество элементов массива");
    int N = Read();
    int[] arr = new int[N];
    
    System.Console.WriteLine("Введите каждый элемент массива");
    for(int i = 0; i < N; i++)
    {
        System.Console.Write($"array[{i}] = ");
        arr[i] = Read();
    }

    return arr;
}


void PrintArray(int[] mas) //печать массива процедура
{
    System.Console.WriteLine();
    System.Console.WriteLine("Массив");

    for(int index = 0; index < mas.Length; index++)
    {
        System.Console.Write(mas[index] + "  ");
    }
}


int CountPositive(int[] list) // счет положительных элементов
{
    int count = 0;
    for(int k = 0; k < list.Length; k++)
    {
        if(list[k] > 0) {count++;};
    }
    return count;
}


//main
int[] array = FillArrayByUser();
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Количество положительных элементов в заданном массиве равно {CountPositive(array)}");

