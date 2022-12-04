﻿// 64. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты по значению.

int[,] Random2DArray(int n,int m,int min=0,int max=10)
{
    int[,] a=new int[n,m];
    Random random=new Random();
    for(int i=0;i<n;i++)
         for(int j=0;j<m;j++)
                a[i,j]=random.Next(min,max+1);
    return a;
}

void Print2DArray(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
        {
     for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],4}");
           System.Console.WriteLine();
        }
}

void SquareNumbers (int[,] a)
{
    for(int j=0;j<a.GetLength(1);j+=2)    
            for(int i=0;i<a.GetLength(0);i+=2)
                 a[i,j]=a[i,j]*a[i,j];                  
}

int[,] a=Random2DArray(2,2);
Print2DArray(a);
System.Console.WriteLine();
SquareNumbers(a);
Print2DArray(a);

