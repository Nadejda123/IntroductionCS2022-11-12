// 72. Показать натуральные числа от M до N, N и M заданы

void Loop(int M,int N)
{
    if (N<=M)
    {
        System.Console.Write($"{N,4}");
        Loop(M,N+1);
    }    
}

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

Loop(n,m);

