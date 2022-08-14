// HomeWork_500_count_even
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] FillArray(int n)
{
    int[] arr = new int[n];
    for (int ind = 0; ind < n; ind++)
    {
        arr[ind] = new Random().Next(100, 999);
        System.Console.Write(arr[ind] + "  ");
    }
    return arr;
}

int N = new Random().Next(10, 20);
System.Console.WriteLine($"Дан массив случайных трехзначных натуральных чисел длиной {N}");
System.Console.WriteLine();

int[] array = FillArray(N);
System.Console.WriteLine();

int count = 0;
for (int i = 0; i < N; i++)
{
    if(array[i] % 2 == 0) {count++;}
}

System.Console.WriteLine($"Количество четных элементов массива равно {count}");