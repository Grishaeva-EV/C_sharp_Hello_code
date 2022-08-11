// HomeWork400_power_x
// In two positive integer numbers a and b
// out a to the power b (a^b)
// Write you own Power without using multiplication(*) and division(/) operators

// The multiplication says how many times to use the number in summation 
// The power of a number says how many times to use the number in a multiplication


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

int multiplication_x_y(int x, int y) //в библиотеке вещественные числа, напишем свою функцию для возведения в степень с блэкджэком
{
    int x_mult = 0;
    for(int i = 0; i < y; i++)
    {
        x_mult = x_mult + x;
    }
    return x_mult;
}

//тело программы
WonderfulFrame();

Console.WriteLine("Введите целое число больше 1 ");
int a = read();
System.Console.WriteLine();

Console.WriteLine("Введите целое число больше 1 ");
int b = read();
System.Console.WriteLine();

int power = a;

for (int i = 1; i < b; i++)
{
    power = multiplication_x_y(power, a);
    // Console.WriteLine($"{a} в степени {i + 1} = " + power);
}

Console.WriteLine($"{a} в степени {b} равно " + power);

WonderfulFrame();