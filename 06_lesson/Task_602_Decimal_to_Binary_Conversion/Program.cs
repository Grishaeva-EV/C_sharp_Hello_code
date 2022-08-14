// Task_602_Decimal_to_Binary_Conversion

int f(int x)
{
    if (x == 0) 
    {
        System.Console.WriteLine("bottom");
        return 1;
    }
    string str = string.Empty;
    System.Console.Write(x + "  ");
    // System.Console.Write((f(x/2) % 2)*10 + (f(x) % 2 + "  "));
    f(x/2);
    System.Console.Write(x % 2);
    // str = str + Convert.ToString(x % 2);
    // System.Console.WriteLine(Convert.ToString(x % 2));

    // str = str + "A";
    // System.Console.WriteLine(str);
    return 0;
}

//int smth = 
f(291);
//Convert.ToString(f(291))
// System.Console.WriteLine();
// System.Console.WriteLine(f(291));

