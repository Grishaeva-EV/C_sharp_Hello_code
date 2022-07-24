// Task006_even_odd: input a number; output is number even or odd

Console.WriteLine("Введите целое число ");
bool result = int.TryParse(Console.ReadLine(), out int N);
if (result != true) //проверка типа введенного значения
{
    Console.WriteLine("Вы ввели не целое число. Запустите программу снова.");
    // оператор прерывания
}
else
{
    if( N % 2 == 0)
    {
        System.Console.WriteLine("Вы ввели чётное число");
    }
    else
    {
        System.Console.WriteLine("Вы ввели нечётное число");
    }
}

