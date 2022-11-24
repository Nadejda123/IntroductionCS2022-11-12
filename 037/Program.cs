// 37. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
int[] RandomIntArray(int size,int min,int max)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max);
    return a;
}

int CountEven(int[] a)
{
  int count=0;
  foreach(int el in a)
        if (el%2==0)
        count++;
    return count;
}

int CountOdd (int[] a)
{ int count=0;
  foreach(int el in a)
        if (el%2!=0)
        count++;
    return count;
}

void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}

int[] a=RandomIntArray(10,100,1000);
Print(a);
System.Console.WriteLine();
System.Console.WriteLine($"Количество нечетных чисел {CountOdd(a)}");
System.Console.WriteLine($"Количество четных чисел {CountEven(a)}");
