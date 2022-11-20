//25. Вывести на экран кубы чисел от 1 до N

int CubeNumber (int Number)
{
  Number=(int)Math.Pow(Number,3);
    return Number;
}

System.Console.WriteLine("Введите значение N: ");
int N=Convert.ToInt32(Console.ReadLine());
int i=1;
while (i<=N )
{
System.Console.Write(CubeNumber(i)+" ");
i++;
}

