// 54. С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. 
// Принять первые числа равными 0 и 1


long [] Fibonacci( int n)
{
    long [] a = new long[n];
    a[0]=0;
    a[1]=1;
    for (int i = 2; i<n; i++)
    {
        a[i]=a[i-1]+a[i-2];
    }
    return a;
}

void PrintArray (long []a)
{
for (int i=0;i<a.Length;i++)
System.Console.Write($"{a[i]}" +", ");
}

Console.Write("Введите N= ");
int N =Convert.ToInt32(Console.ReadLine());
long []a=Fibonacci(N);
PrintArray(a);
