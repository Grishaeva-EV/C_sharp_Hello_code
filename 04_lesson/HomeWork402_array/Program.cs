// HomeWork402_array
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

void WonderfulFrame() //для красоты
{
    System.Console.WriteLine(); 
    System.Console.WriteLine("=============================");
    System.Console.WriteLine(); 
}

double read() //проверяем, что там введено, ддосим, пока не получим число
{      
    bool result = double.TryParse(Console.ReadLine(), out double A);
    if (result != true) //проверка типа введенного значения
    {
        while(result != true)
        {
            Console.WriteLine("Вы ввели не число. Введите число");
            result = double.TryParse(Console.ReadLine(), out A);
        }    
    }
    return(A);
}

double[] FillArrayByUser() //проба функции без параметра
{
    double[] array = new double[8];//задаем массив с длиной 8 (по условию)
    for (int i = 0; i < 8; i++)//Присваиваем значение каждой ячейки массива через запрос к пользователю
    {
        System.Console.Write($"Введите значение {i + 1}-го элемента массива ");
        // double k = read(); // считываем значение, преобразуем в интежер и сохраняем доп переменную K
        array[i] = read(); // х.з. почему нужно ДВЕ строки и в одну присвоить элементу все рушится
    }
    return array; //возвращаем наш массив
}


void PrintArrayFor(double[] col) //выводим на печать массив с помощью цикла со счетчиком
{
    for (int i = 0; i < col.Length; i++)
        {
            System.Console.WriteLine($"array[{i}] = {col[i]}");
        }
}


//тело программы
WonderfulFrame();

double[] array_global = FillArrayByUser(); 

PrintArrayFor(array_global); //передаем заполненный массив в процедуру с параметром. Или метод с ключевым словом void
System.Console.WriteLine(); 

WonderfulFrame();
