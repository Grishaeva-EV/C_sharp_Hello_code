// HomeWork_502_difference_max_min
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива


double[] FillArray(int n)
{
    double[] arr = new double[n];
    for (int ind = 0; ind < n; ind++)
    {
        arr[ind] = new Random().NextDouble()*10000;
        System.Console.WriteLine($"arr[{ind}] = {arr[ind]}");
    }
    return arr;
}

int N = new Random().Next(5, 10);
System.Console.WriteLine($"Дан массив случайных трехзначных натуральных чисел длиной {N}");
System.Console.WriteLine();

double[] array = FillArray(N);
System.Console.WriteLine();

// double min = array[0]; //здесь мы просто сохраняем сами значения элементов макс и мин
// double max = array[0];
// for (int i = 0; i < N; i++)
// {
//     if(array[i] > max) {max = array[i];}
//     if(array[i] < min) {min = array[i];}
// }

int min = 0; 
int max = 0;
//здесь мы сохраняем индекс элементов макс и мин, 
//что позволит нам выводить и значения элементов, и его индекс
for (int i = 0; i < N; i++)
{
    if(array[i] > array[max]) {max = i;}
    if(array[i] < array[min]) {min = i;}
}

// пока решала, забыла что нужно
// System.Console.WriteLine($"Наибольший элемент массива равен {array[max]}, а его индекс равен {max}");
// System.Console.WriteLine($"Наименьший элемент массива равен {array[min]}, а его индекс равен {min}");
// System.Console.WriteLine();

System.Console.WriteLine($"Разница между наибольшим и наименьшим элементами массива равна " + (array[max] - array[min]));
System.Console.WriteLine();