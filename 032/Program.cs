// 32. Задать массив из 8 целых элементов и вывести их на экран

void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}

int N=8;
int[] t=new int[N];
for(int i=0;i<t.Length;i++)
    t[i]=Convert.ToInt32(Console.ReadLine());


Print(t);
