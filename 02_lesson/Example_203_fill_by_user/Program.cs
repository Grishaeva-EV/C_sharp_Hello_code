// Example_203_fill_by_user: cycle with a counter FOR, method without parameter, method without parameter and VOID, concatenation


int[] FillArrayByUser() //проба функции без параметра
{
    System.Console.WriteLine("Введите длину массива");
    int n = Int32.Parse(Console.ReadLine());//Сохраняем введенное число (размер массива) в переменную n
    int[] array = new int[n];//объявляем и инициализируем массив с длиной n и значениями 0 по умолчанию (что за бредовый язык)
    for (int i = 0; i < n; i++)//Присваиваем значение каждой ячейки массива через запрос к пользователю
    {
        System.Console.WriteLine("Введите значение элемента массива");
        int k = Int32.Parse(Console.ReadLine()); // считываем значение, преобразуем в интежер и сохраняем доп переменную K
        array[i] = k; // х.з. почему нужно ДВЕ строки и в одну присвоить элементу все рушится
    }
    return array; //возвращаем наш массив
}
  
//void PrintArray(int[] col) //здесь мы печатаем и ничего не передаем, значит процедуры достаточно
//{
//    int count = col.Length;
//    int position = 0;
//    while (position < count)
//    {
//        System.Console.WriteLine(col[position]);
//        position++;
//    }
//}

void PrintArrayFor(int[] col) //выводим на печать массив с помощью цикла со счетчиком
{
    for (int i = 0; i < col.Length; i++) // на фиг доп переменные, если можно внутрь оператора запихнуть сразу вычисление длины
        {
            System.Console.WriteLine("array[" + i + "] = " + col[i]); //проба конкатенации строк в выводе
        }
}

int[] array_global = FillArrayByUser(); //объявляем целочисленый массив и заполняем его через функцию без параметров

System.Console.WriteLine(); //добавим пустых строк для удобства восприятия вывода

PrintArrayFor(array_global); //передаем заполненный массив в процедуру с параметром. Или метод с ключевым словом void


//PrintArray(array_global);