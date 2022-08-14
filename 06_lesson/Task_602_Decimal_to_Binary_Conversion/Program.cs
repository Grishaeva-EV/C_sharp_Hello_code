// Task_602_Decimal_to_Binary_Conversion

// void PrintArrayFor(int[] col, int ind) //выводим на печать ind элементов массива
// {
//     for (int j = 0; j < ind; j++)
//         {
//             System.Console.Write(col[j] + "  ");
//         }
// }

//int Decimal_to_Binary_Conversion(int x, int[] arr = new int[100000], int i = 0)
int f(int x)
{
    if (x == 0) 
    {
        System.Console.WriteLine("bottom");
        return 1;
    }
    System.Console.Write(x + "  ");
    // System.Console.Write((f(x/2) % 2)*10 + (f(x) % 2 + "  "));
    f(x/2);
    System.Console.Write(x % 2);

    return x % 2;
}

int A = new Random().Next(100, 1000);

// int[] arr = new int[100000];
// int i = 0;


int smth = f(A);
System.Console.WriteLine(smth);

