// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5; 782 -> 8; 918 -> 1

System.Console.WriteLine("Введите целое трехзначное число (от 100 до 999)");
Console.Write("number = ");

bool result = int.TryParse(Console.ReadLine(), out int number);
if (result != true) //проверка типа введенного значения
{
    Console.WriteLine("Вы ввели не целое число. Запустите программу снова.");
}    
else
    if(number < 100 | number > 999) //проверка величины значения
    {
        Console.WriteLine("Вы ввели целое число за переделами диапазона от 100 до 999");
        Console.WriteLine("Запустите программу снова.");
    }
    else
    {
        System.Console.WriteLine("вторая цифра = " + (number % 100)/10);        
    }



