// Task003_day_of_week 
// input a number of [1 .. 7]
// output day_of_week

Console.WriteLine("Введите натуральное число от 1 до 7");
Console.Write("A = ");

bool result = int.TryParse(Console.ReadLine(), out int A);
if (result != true) //проверка типа введенного значения
{
    Console.WriteLine("Вы ввели не целое число. Запустите программу снова.");
}    
else
    if(A > 7 || A < 0) //проверка величины значения
    {
        Console.WriteLine("Вы ввели целое число за переделами диапазона от 1 до 7");
        Console.WriteLine("Запустите программу снова.");
    }
    else
    {
        //allright введено натуральное число от 1 до 7

        if(A == 4)
        {
            // A = 4 
            Console.WriteLine("Четверг"); 
        }
        else
        {
                // A <> 4
            if(A > 4)
            {
                // A > 4 => 5 or 6 or 7
                if(A == 6)
                {
                    // A = 6 
                    Console.WriteLine("Суббота");
                }            
                    else
                    {
                        // A <> 6
                        if(A > 6)
                        {
                            //7
                            Console.WriteLine("Воскресенье");
                        }
                        else
                        {
                            //5
                            Console.WriteLine("Пятница");
                        }
                    }
            }
            else
            {
                // A < 4 => 1 or 2 or 3
                if(A == 2)
                {
                    //2
                    Console.WriteLine("Вторник");
                }
                else
                {
                    if(A > 2)
                    {
                        //3
                        Console.WriteLine("Среда");
                    }
                    else
                    {
                        //1
                        Console.WriteLine("Понедельник");
                    }
                }
            }
                
        }
    }
