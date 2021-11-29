int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 73;
int b1 = 66;
int c1 = 666;
int a2 = 43;
int b2 = 88;
int c2 = 99832;
int a3 = 61;
int b3 = 99999;
int c3 = 70;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);

Console.WriteLine(max1);
Console.WriteLine(max2);
Console.WriteLine(max3);

Console.Write("Максимальное из всех чисел - ");
Console.WriteLine(max);

