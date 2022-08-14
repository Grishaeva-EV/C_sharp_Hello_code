// HomeWork_501_sum_odd_position
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях
Console.WriteLine("Hello, World!");


int[] FillArray(int n)
{
    int[] arr = new int[n];
    for (int ind = 0; ind < n; ind++)
    {
        arr[ind] = new Random().Next(1, 999);
        System.Console.Write(arr[ind] + "  ");
    }
    return arr;
}

int N = new Random().Next(10, 20);
System.Console.WriteLine($"Дан одномерный массив случайных натуральных чисел длиной {N}");
System.Console.WriteLine();

int[] array = FillArray(N);
System.Console.WriteLine();

int count = 0; 
//т.к. задачу задавал человек, примем допущение, что он не программист и считает с 1 элементы массива
//поэтому элементы с номерами 0, 2, 4 и т.д. будут по мнению заказчика нечетными
//для определения нечетных элементов по четности индекса массива, как в программе
//начинать цикл будем с i=1
for (int i = 0; i < N; i+=2)
{
    count += array[i];
}

System.Console.WriteLine($"Сумма нечетных (при счете с 1, как ведут счет детские человеки) элементов массива равна {count}");