// 302Home_work_progressive_cube
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
// input int number; output cube numbers [1 .. N]

void WonderfulFrame() //для красоты
{
    System.Console.WriteLine(); 
    System.Console.WriteLine("=============================");
    System.Console.WriteLine(); 
}

int read() //проверяем, что там введено, ддосим, пока не получим натуральное число больше 1
{      
    bool result = int.TryParse(Console.ReadLine(), out int A);
    if (result != true || A < 2) //проверка типа введенного значения
    {
        while(result != true)
        {
            Console.WriteLine("Вы ввели не целое число больше 1. Повторите попытку.");
            result = int.TryParse(Console.ReadLine(), out A);
        }    
    }
    return(A);
}

int power_x(int x, int power) //в библиотеке вещественные числа, напишем свою функцию для возведения в степень с блэкджэком
{
    int x_pw = 1;
    for(int i = 0; i < power; i++)
    {
        x_pw = x_pw * x;
    }
    return x_pw;
}

//тело программы
WonderfulFrame();

Console.WriteLine("Введите целое число больше 1 ");
int N = read();
System.Console.WriteLine();
Console.WriteLine("Tаблица кубов чисел от 1 до " + N);
for (int i = 1; i < N + 1; i++)
{
    Console.Write(power_x(i, 3) + " ");
}

WonderfulFrame();