// 67. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

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

System.Console.WriteLine("Количество строк =");
int n=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Количество столбцов =");
int m=Convert.ToInt32(Console.ReadLine());
int[,]a= Random2DArray(n, m);
Print2DArray(a);

double[] b=new double[n];
    for (int j=0,k=0;j<m;j++) 
    {
        double summa=0;
        for (int i=0;i<n;i++) 
        {
            summa+=a[i,j];
        }
        b[k]=summa/n;
        Console.WriteLine("Среднее арифметическое столбца "+(j+1)+" равно: "+b[k]);
        k++;
    }    

