// Task_600_reverse_array
// Напишите программу, которая перевернёт одномерный массив
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)



int[] FillArray(int n) //целочисленный случайно заполненный массив с заданной длиной
{
    int[] arr = new int[n];
    for (int ind = 0; ind < n; ind++)
    {
        arr[ind] = new Random().Next(1, 100000);
        System.Console.Write(arr[ind] + "  "); //кажется, что вызов цикла для заполнения, а потом метода с циклом для печати
        //будет дольше, чем печать сразу при создании элемента
    }
    return arr;
}

void PrintArrayFor(int[] col) //выводим на печать массив 
{
    for (int i = 0; i < col.Length; i++)
        {
            System.Console.Write(col[i] + "  ");
        }
}

int N = new Random().Next(10, 20); //но длину тож случайно зададим, что уж тут
System.Console.WriteLine($"Дан массив случайных чисел длиной {N}"); //ха-ха, дан... да...
System.Console.WriteLine();

int[] array = FillArray(N);
System.Console.WriteLine();

int count = 0;
for (int i = 0; i < (N / 2); i++) //если идти дальше середины, то развернем снова и получится первоначальный порядок
//если количество элементов нечетное, то центральный элемент не трогаем, т.к. N = 2* N/2 +1 из-за целочисленного деления Си шарп
{
    count = array[i]; //it's a classic: swapping two variable value with using third variable
    array[i] = array[N - i - 1]; //и ошибка тож по классике, единичку из длины не вычла для нулевого индекса
    array[N - i - 1] = count;
}

System.Console.WriteLine("Таки получите свой вывернутый массив, одномерный");
PrintArrayFor(array);