// Task_602_Decimal_to_Binary_Conversion


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

int f(int x)
{
    if (x == 0)     {return 0;}
    return f(x/2) * 10 + x % 2;
}


System.Console.WriteLine("введите натуральное число больше 1");
int a = read();

System.Console.WriteLine();
System.Console.WriteLine("его двоичное представление");
System.Console.WriteLine(f(a));

