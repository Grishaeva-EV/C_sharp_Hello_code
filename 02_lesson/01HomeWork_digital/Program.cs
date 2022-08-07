// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5; 78 -> третьей цифры нет; 32679 -> 6
//числовое решение

int n = new Random().Next(0, 100000); //если задает пользователь, то изначально строковый тип
System.Console.WriteLine("Случайное число = " + n);

int index = 0; //счетчик количества разряда
int number = n; //запасная переменная, чтобы не затереть
while(number / 10 > 0) 
{
    number = number / 10;
    index++;
}
//System.Console.WriteLine("Количество разрядов = " + (index + 1)); 
//когда останется одна цифра, цикл не сработает и индекс не увеличится

if (index < 3)
{
    System.Console.WriteLine("В этом числе меньше 3 цифр. Третья цифра отсутствует");
}
else
{
    int number1 = n / Convert.ToInt32(Math.Pow (10, index)); //это будет первая цифра числа
    int number3 = n / Convert.ToInt32(Math.Pow (10, index - 2)); //три первых цифры числа

    //System.Console.WriteLine("первая цифра числа = " + number1);
    //System.Console.WriteLine("три первых цифры числа = " + number3);
    System.Console.WriteLine("третья цифра заданного числа = " + number3 % 10);
}