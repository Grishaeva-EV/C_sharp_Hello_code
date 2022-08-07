// Example_203: request x from the user; find index of elements = x

//System.Console.WriteLine("Введите количество элементов массива");
//System.Console.WriteLine("(натуральное число)");
//System.Console.WriteLine("N = ");

// bool result = int.TryParse(Console.ReadLine(), out int N);
//if ((result != true) | (N < 1)) //проверка типа введенного значения
//{
    //Console.WriteLine("Вы ввели не натуральное число. Запустите программу снова.");
//}    
//else
    
System.Console.WriteLine("Введите значения каждого элемента массива");
int index = 0;
int[] array = new int[3];
while(index < 3)
{
   // System.Console.Write("array[");
    System.Console.Write(index);
  //  System.Console.Write("] = ");
    array[index] = new System.Console.ReadLine();
    index++;
}    

System.Console.WriteLine("Введите искомое значение среди элементов массива");
System.Console.WriteLine("x =");
int x = System.Console.ReadLine();

while(index < N)
{    
    if(array[index] == x)
    {
        System.Console.Write("array[");
        System.Console.Write(index);
        System.Console.Write("] = ");
        System.Console.WriteLine(x);
    }
    
    index ++;
}
