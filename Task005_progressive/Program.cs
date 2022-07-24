// Task005_progressive: input int number; output arithmetic progression [-N .. N]
Console.WriteLine("Введите число ");
bool result = int.TryParse(Console.ReadLine(), out int N);
if (result != true) //проверка типа введенного значения
{
    Console.WriteLine("Вы ввели не целое число. Запустите программу снова.");
    // оператор прерывания
}
else
{

    if(N < 0)
    {
        N = -N;
    }


    System.Console.WriteLine("Целые числа от -N до N");
    System.Console.Write(-N); 
    //избавляемся от запятой после последнего числа
    //на нов строке печатаем первое число диапазона ДО цикла
    //без перевода строки
    //счетчик начинается со второго числа диапазона
    int count = -N + 1;

    while(count < (N + 1)) 
    //если заданное число 0, то цикл не отработает
    //запятая после напечатанного нуля не появится
    {
        System.Console.Write(", "); //запятую и пробел после предыдущего числа
        System.Console.Write(count); //само число
        count = count + 1;
    }
}