// Task_603_fibonacci_numbers WITH recursion

int N = new Random().Next(20, 30); //но длину тож случайно зададим, что уж тут
// int N = 10; //для ручной проверки
System.Console.WriteLine($"Первые {N} чисел последовательности Фиббоначи:"); 
System.Console.WriteLine();

int[] array = new int [N];
array[0] = 0;
array[1] = 1;
System.Console.Write(array[0] + "  " + array[1] + "  ");
// System.Console.Write("0  1  ");  //первые же два числа мы знаем, можно и так начало вывести

// for (int i = 2; i < N; i++) 
// {
//     array[i] = array[i - 1] + array[i - 2];
//     System.Console.Write(array[i] + "  ");
// }

int[] f(int[] arr, int i)
{
    if (i == 1) {
        // arr[0] = 0;
        // arr[1] = 1;
        return arr;}
    arr = f(arr, i-1);
    arr[i] = arr[i - 1] + arr[i - 2];
    System.Console.Write(arr[i] + "  ");
    return arr;
}
f(array, array.Length - 1);