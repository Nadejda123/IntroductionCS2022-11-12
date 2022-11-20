//Алгоритм Евклида
int k=0;
int GCD (int a, int b)
{
 while(a!=b)
    {
     k++;
     if (a>b)
         a=a-b;
        else
         b=b-a;
    }
      return a;
}
int QickGCD (int a, int b)
{
 while(a!=0 && b!=0)
    {
     k++;
     if (a>b)
         a=a%b;
        else
         b=b%a;
    }
      return a;

}
 System.Console.WriteLine(GCD(5,10000));
 System.Console.WriteLine(k);
k=0;
 System.Console.WriteLine(QickGCD(5,10000));
 System.Console.WriteLine(k);

