// Task007_last_digit: input a number of [100 .. 999]; output day_of_week
Console.WriteLine("Hello, World!");


Console.WriteLine("Введите натуральное трехзначное число (от 100 до 999)");
Console.Write("A = ");

bool result = int.TryParse(Console.ReadLine(), out int A);
if (result != true) //проверка типа введенного значения
{
    Console.WriteLine("Вы ввели не целое число. Запустите программу снова.");
}    
else
    if(A > 999 || A < 100) //проверка величины значения
    {
        Console.WriteLine("Вы ввели не трехзначное натуральное число (от 100 до 999)");
        Console.WriteLine("Запустите программу снова.");
    }
    else
    {
        //allright введено натуральное число от 100 до 999
        Console.Write("Последняя цифра введенного числа равна ");
        Console.WriteLine(A % 10);
    }