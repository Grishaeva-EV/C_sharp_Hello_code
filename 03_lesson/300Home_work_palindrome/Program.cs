// 300Home_work_palindrome
// Программа принимает на вход натуральное число и проверяет, является ли оно палиндромом.
// пятизначное просто, тк мы знаем его количество разрядов

void WonderfulFrame() //для красоты
{
    System.Console.WriteLine(); 
    System.Console.WriteLine("=============================");
    System.Console.WriteLine(); 
}

int[] ArrayFromNumber(int number) //создает массив из цифр заданного числа number
{
    int index = 1; //счетчик цикла, в котором сохранится количество разрядов в числе
    int numberClone = number;
    while(numberClone / 10 > 0) 
    {
        numberClone = numberClone / 10;
        index++;
    }
    
    int[] array = new int[index]; //объявляем массив с вычисленной длиной и заполняем нулями
    for (int i = 0; i < index - 1; i++) // создает массив из цифр заданного числа number
    {
            array[i] = number % 10; //остаток от деления на 10 есть последняя цифра числа
                //т.к. нам массив нужен для сравнения
                // то без разницы, сохраним мы число в массив в том или обратном порядке
                // для простоты буду сохранять последнюю цифру в текущий по порядку элемент (для обратного взяла бы array[index - i])
            number = number / 10; //"сокращаем" число на разряд
                // number - локальная переменная, можно ее копию не сохранять
    }
    array[index - 1] = number;
    //количество итераций было на 1 меньше, чем количество разрядов
    // в number сохранилось однозначное числа - первая цифра изначального числа
    // сохраняем number в последний элемент массива

    return array;   
}

void PrintArrayFor(int[] col) //выводим на печать массив с помощью цикла со счетчиком
{
    for (int i = 0; i < col.Length; i++)
        {
            System.Console.WriteLine($"array[{i}] = {col[i]}");
        }
}

void Сompare(int[] arr) //сравниваем элементы массива
{
    int ind = 0; 
    while((arr[ind] == arr[arr.Length - ind - 1]) & (ind < arr.Length / 2)) 
        // если число нечет, нет смысла "серединку" сравнивать с самим собой
        {
            ind++;
        }
    if (ind == arr.Length / 2)
    {
        System.Console.WriteLine("палиндром");
    }
    else
    {
        System.Console.WriteLine("не палиндром");
    }
}

//тело программы
WonderfulFrame();

// int n = 32013; //для ручного теста
int n = new Random().Next(1, 1000000000); //создаем натуральное число
System.Console.WriteLine("Заданное число = " + n);
System.Console.WriteLine();

int[] array_global = ArrayFromNumber(n); 

PrintArrayFor(array_global); //передаем заполненный массив в процедуру с параметром. Или метод с ключевым словом void
System.Console.WriteLine(); 

Сompare(array_global);
System.Console.WriteLine(); 

WonderfulFrame();