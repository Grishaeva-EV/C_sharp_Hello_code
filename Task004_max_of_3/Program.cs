// Task004_max_of_3
// input 3 numbers 
// output max

Console.WriteLine("Введите три рациональных числа. Разделителем является запятая , ");
Console.WriteLine("Введите число A");
Console.Write("A = ");

bool result = double.TryParse(Console.ReadLine(), out double A);
if (result != true) //проверка типа введенного значения. Хорошо бы как функцию оформить
// а запрос чисел как цикл
{
    Console.WriteLine("Вы ввели не число. Запустите программу снова.");
    //оператор прерывания исполнения программы либо перехода на строку с повторным запросом
}

Console.WriteLine("Введите число B");
Console.Write("B = ");
result = double.TryParse(Console.ReadLine(), out double B);
if (result != true) //проверка типа введенного значения
{
    Console.WriteLine("Вы ввели не число. Запустите программу снова.");
    //оператор прерывания исполнения программы либо перехода на строку с повторным запросом
}

Console.WriteLine("Введите число C");
Console.Write("C = ");
result = double.TryParse(Console.ReadLine(), out double C);
if (result != true) //проверка типа введенного значения
{
    Console.WriteLine("Вы ввели не число. Запустите программу снова.");
    //оператор прерывания исполнения программы либо перехода на строку с повторным запросом
}

double max = 0;

if(A > B)
{
    max = A;
}
else
{
        max = B;
}

if(C > max)
{
    max = C;
}

Console.Write("Наибольшее из введенных Вами чисел равно ");
Console.WriteLine(max);