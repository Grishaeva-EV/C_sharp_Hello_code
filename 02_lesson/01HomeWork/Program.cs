// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5; 78 -> третьей цифры нет; 32679 -> 6

int n = new Random().Next(1, 10); //если задает пользователь, то изначально строковый тип
string str = n.ToString();
Console.WriteLine("The length of '{0}' is {1}", str, str.Length); //куда удобнее конкатенации

int startIndex = 2; //отсчет символов в строке как и в массиве начинается с 0
int length = 1;

if (str.Length < 3)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    String substring = str.Substring(startIndex, length); //на основе примера из документации
    Console.WriteLine("The third digit of '{0}' is {1}", str, substring);
}