// Task_604_copy_array_1_by_1_cycle

int[] arr(int n)
{
    System.Console.WriteLine("Первоначальный массив");
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(0, 100);
        System.Console.Write(array[i] + "  ");
    }
    return array;
}

int[] copy_1_by_1(int[] arr1)
{
    int[] arr2 = new int[arr1.Length];
    for(int i = 0; i < arr1.Length; i++)
    {
        arr2[i] = arr1[i];
    }
    
    return(arr2);
}

int N = new Random().Next(10, 20);
int[] array1 = arr(N);
int[] array2 = new int[array1.Length];
array2 = copy_1_by_1(array1);

System.Console.WriteLine();
System.Console.WriteLine("Новый массив");
for(int i = 0; i < array2.Length; i++)
{
    System.Console.Write(array2[i] + "  ");
}

