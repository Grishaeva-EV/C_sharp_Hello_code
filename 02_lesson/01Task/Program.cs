// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления. 
//34, 5 -> не кратно, остаток 4 16, 4 -> кратно

System.Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(System.Console.ReadLine()); //конвертируем строку в число
System.Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(System.Console.ReadLine()); //конвертируем строку в число

if (number2 < number1 | number2 <= 0 | number1 <= 0)
{
    System.Console.WriteLine("Невозможно определить кратность второго числа первому");
}
else
{
    if (number2 % number1 == 0)
    {
        System.Console.WriteLine(number2 + " кратно " + number1);
    }
    else
    {
        System.Console.WriteLine(number2 + " делится на " + number1 + " с остатком " + number2 % number1);
}
}