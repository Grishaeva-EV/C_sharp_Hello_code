// Напишите программу, которая принимает на вход число и 
//проверяет, кратно ли оно одновременно 7 и 23. 
//14 -> нет 46 -> нет 161 -> да

System.Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(System.Console.ReadLine()); //конвертируем строку в число

if (number1 < 23 * 7)
{
    System.Console.WriteLine("Невозможно определить кратность числа 23 и 7");
}
else
{
    if (number1 % (23 * 7) == 0)
    {
        System.Console.WriteLine(number1 + " одновременно кратно и 23, и 7");
    }
    else
    {
        System.Console.WriteLine(number1 + " не кратно одновременно и 23, и 7");
}
}