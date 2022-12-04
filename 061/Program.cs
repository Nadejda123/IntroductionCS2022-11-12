//Показать двумерный массив размером m×n заполненный вещественными случайными числами


double[,] Random2DArray(int n,int m,int min=0, int max=10)
{
    double[,] a=new double[n,m];
    Random rand=new Random();
    for(int i=0;i<n;i++)
         for(int j=0;j<m;j++)
                a[i,j] = Convert.ToDouble(rand.Next(min, max)/10.0);
    return a;
}

void Print(double[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
        {
     for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],5}");
           System.Console.WriteLine();
        }
}


double[,] a=Random2DArray(5,5,10,20);
Print(a);

