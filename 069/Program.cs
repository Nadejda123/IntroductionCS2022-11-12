// 69. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.


void Print2DArray(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
        {
     for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],4}");
           System.Console.WriteLine();
        }
}

void Swap(ref int a,ref int b)
{
    int t=a;
    a=b;
    b=t;
}


void Sort2DArray(int[,] a)
{
    for(int i=0;i<a.GetLength(1)-1;i++)    
        for(int k=0;k<a.GetLength(0);k++)
            for(int j=0;j<a.GetLength(0);j++)
               if (a[i,j]>a[i,j+1])
               Swap(ref a[i,j],ref a[i,j+1]);                                  
}


int [,]a= {{1,4,7,2},{5,9,2,3},{8,4,2,4}};
Print2DArray(a);
Sort2DArray(a);
System.Console.WriteLine();
Print2DArray(a);



