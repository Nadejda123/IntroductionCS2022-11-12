// 56. Написать программу копирования массива



int [] RandomIntArray(out int[] a, int size,int min=0,int max=100)
{
    a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max);    
        return a;
}
void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}


int size=Convert.ToInt32(Console.ReadLine());
int [] a;
a=RandomIntArray(out a,size);
Print(a);
int [] b=new int[a.Length];
for (int i=0;i<a.Length;i++)
{
    b[i]=a[i];
}
System.Console.WriteLine();
Print(b);

