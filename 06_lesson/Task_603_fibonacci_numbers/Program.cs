// Task_603_fibonacci_numbers without recursion

int N = new Random().Next(10, 20); //но длину тож случайно зададим, что уж тут
System.Console.WriteLine($"Первые {N} чисел последовательности Фиббоначи:"); 
System.Console.WriteLine();

int[] array = new int [N];
array[0] = 0;
array[1] = 1;
System.Console.Write(array[0] + "  " + array[1] + "  ");
// System.Console.Write("0  1  ");  //первые же два числа мы знаем, можно и так начало вывести

for (int i = 2; i < N; i++) 
{
    array[i] = array[i - 1] + array[i - 2];
    System.Console.Write(array[i] + "  ");
}
