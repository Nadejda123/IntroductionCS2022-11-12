void Swap(ref int a,ref int b)//reference-ссылка
{
    int t=a;
    a=b;
    b=t;
}



void Calculator(int a,int b,out int sum,out int multi)
{
    sum=a+b;
    multi=a*b;
}

int a=7,b=9;

System.Console.WriteLine($"a={a} b={b}");
Swap(ref a,ref b);

/*bool flag;
int x;
do
{
    flag=int.TryParse(Console.ReadLine(),out x);
    if (flag==false) System.Console.WriteLine("Введете целое число!");
}
while(flag==false);
*/

System.Console.WriteLine($"a={a} b={b}");
int sum,multi;
Calculator(a,b,out sum,out multi);
System.Console.WriteLine(sum);
System.Console.Write(multi);