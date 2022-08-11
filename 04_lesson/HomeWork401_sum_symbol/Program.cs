// HomeWork401_sum_symbol
// In positive integer number a
// Out sum digits of a

void WonderfulFrame() //для красоты
{
    System.Console.WriteLine(); 
    System.Console.WriteLine("=============================");
    System.Console.WriteLine(); 
}

int[] ArrayFromNumber(int number) //создает массив из цифр заданного числа number
{
    int index = 1; //счетчик цикла сохранит количество разрядов числf
    int numberClone = number;
    while(numberClone / 10 > 0) 
    {
        numberClone = numberClone / 10;
        index++;
    }
    
    int[] array = new int[index]; 
    for (int i = 0; i < index - 1; i++) // массив из цифр заданного числа number
    {
            array[i] = number % 10; //остаток от деления на 10 есть последняя цифра числа
            number = number / 10; //"сокращаем" число на разряд              
    }
    array[index - 1] = number;

    return array;   
}

int SumElementArray(int[] arr) //multiplication all elements of array
{
    int ind = 0; 
    for(int i = 0; i < arr.Length; i++)
    {
        ind = ind + arr[i];
    }

    return ind;
}

//тело программы
WonderfulFrame();

// int n = 32013; //для ручного теста
int n = new Random().Next(1, 1000000000); //создаем натуральное число
System.Console.WriteLine("Заданное число = " + n);
System.Console.WriteLine();

int[] array_global = ArrayFromNumber(n); 

//PrintArrayFor(array_global); //передаем заполненный массив в процедуру с параметром. Или метод с ключевым словом void
//System.Console.WriteLine(); 

System.Console.WriteLine($"Сумма цифр числа {n} равна " + SumElementArray(array_global)); 

WonderfulFrame();
