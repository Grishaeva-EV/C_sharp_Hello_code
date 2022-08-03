// Example_201: find max of 9 numbers by methods

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 43;
int a2 = 33;
int a3 = 63;
int a4 = 23;
int a5 = -657;
int a6 = 343;
int a7 = 96;
int a8 = 1;
int a9 = 2;

// int max1 = Max(a1, a2, a3);
// int max2 = Max(a4, a5, a6);
// int max3 = Max(a7, a8, a9);
// int max = Max(max1, max2, max3);

int max = Max(
    Max(a1, a2, a3),
    Max(a4, a5, a6),
    Max(a7, a8, a9));

System.Console.Write("max = ");
System.Console.WriteLine(max);