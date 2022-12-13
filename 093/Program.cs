/*Задача 93: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/

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


int[,] mult(int[,] ar1, int[,] ar2)
{
    int[,] m = new int[ar1.GetLength(0), ar2.GetLength(1)];
    for (int i = 0; i < ar1.GetLength(0); ++i)
        for (int j = 0; j < ar2.GetLength(1); ++j)
           // for (int k = 0; k < ar2.GetLength(1); ++k)
            m[i, j] += ar1[i, j] * ar2[i, j];
            return m;
        }
System.Console.WriteLine("ВВедите размер массива: ");
int a=Convert.ToInt32(Console.ReadLine());
//int[,] ar1 = { {1, 4, 7, 2 }, { 5, 9, 2, 3 }, {8, 4, 2, 4},{5, 2, 6, 7} };
int [,] ar1 =Random2DArray(a,a);
//int[,] ar2 = { { 1, 5, 8, 5}, {4, 9, 4, 2 }, {7, 2, 2, 6}, {2, 3, 4, 7} };
int [,] ar2 =Random2DArray(a,a);
int[,] m = mult(ar1, ar2);
Print2DArray(ar1);
System.Console.WriteLine();
Print2DArray(ar2);
System.Console.WriteLine();
Print2DArray(m);