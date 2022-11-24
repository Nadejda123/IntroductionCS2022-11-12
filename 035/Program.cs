// 35. Написать программу замены элементов массива на противоположные



void Revers(int[] a)
    {
      for (int i = 0; i < a.Length; ++i)
        if (a[i] > 0 || a[i]<0) a[i] = -a[i];
    }
   
void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}

int N=5;
int[] m=new int[N];
for(int i=0;i<m.Length;i++)
    m[i]=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(" Изначальные данные: ");
Print(m);
Revers (m);
System.Console.WriteLine();
System.Console.WriteLine(" Противоположные значения: ");
Print(m);