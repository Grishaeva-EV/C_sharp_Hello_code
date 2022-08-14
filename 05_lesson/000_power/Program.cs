// // HomeWork400_power_x RECURSION
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
    //if (result != true || A < 2) //проверка типа введенного значения
    while(result != true || A < 2) // убрала if, т.к. цикл выполнится только если условие тру
    {
        Console.WriteLine("Вы ввели не целое число больше 1. Повторите попытку.");
        result = int.TryParse(Console.ReadLine(), out A);
    }    
    return(A);
}

int multiplication_x_y(int x, int y) 
{
    if (y < 1) {
        System.Console.WriteLine("дошли до дна");
        return 0;
        
        }
    else
        System.Console.WriteLine($"прямой ход x= {x}; y= {y};");
    x = multiplication_x_y(x, y-1) + x;
        System.Console.WriteLine($"j,hfn ход x= {x}; y= {y};");
    return x;
}

//тело программы
WonderfulFrame();

Console.WriteLine("Введите целое число больше 1 ");
int a = read();
System.Console.WriteLine();

Console.WriteLine("Введите целое число больше 1 ");
int b = read();
System.Console.WriteLine();

// int power = b;

multiplication_x_y(a, b);

// for (int i = 1; i < b; i++)
// {
//     power = multiplication_x_y(a, a);
//     Console.WriteLine($"{a} в степени {i + 1} = " + power);
// }

// Console.WriteLine($"{a} в степени {b} равно " + power);

//     if (b < 2) {return a;}
//     else {power = multiplication_x_y( multiplication_x_y(a, b-1), a);}


WonderfulFrame();