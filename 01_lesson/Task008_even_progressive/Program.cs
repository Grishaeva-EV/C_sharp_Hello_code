// Task008_even_progressive: input int number; 
// output arithmetic progression of even numbers[1 .. N]
Console.WriteLine("Введите натуральное число ");
bool result = int.TryParse(Console.ReadLine(), out int N);
if (result != true || N < 1) //проверка типа введенного значения
{
    Console.WriteLine("Вы ввели не натуральное число. Запустите программу снова.");
    // оператор прерывания
}
else
{
    if(N == 1)
    {
        System.Console.WriteLine("Во множестве натуральных чисел, состоящем только из числа 1, нет чётных чисел");
    }
    else
    {
        System.Console.Write("Чётные числа от 1 до ");
        System.Console.WriteLine(N);
        System.Console.Write(2); 
        //избавляемся от запятой после последнего числа
        //на нов строке печатаем первое чётное число 
        //ДО цикла и БЕЗ без перевода строки
        //счетчик начинается с 4. Если задано число 3, то цикл не запустится
        //запятая после напечатанной 2 не появится
        int count = 4;

        while(count < (N + 1)) 
        {
            System.Console.Write(", "); //запятую и пробел после предыдущего числа
            System.Console.Write(count); //само число
            count = count + 2;
        }
    }
}
