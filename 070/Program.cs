// 70. Показать натуральные числа от 1 до N, N задано

void Loop(int N,int i=1)
{
    if (i<=N)
    {
        System.Console.Write($"{i,4}");
        Loop(N,i+1);
    }    
}

int n = Convert.ToInt32(Console.ReadLine());
Loop(n);
