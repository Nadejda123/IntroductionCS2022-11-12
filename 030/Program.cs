//30. Написать программу вычисления произведения чисел от 1 до N (Факториал числа  N! )

int Factorial (int F, int count)
{
    int i=1;
    while (i<count)
    {
        F=F*i;
        i=i+1;
    }
    return F;
}

System.Console.WriteLine("Введите значение N: ");
int N=Convert.ToInt32(Console.ReadLine());
System.Console.Write($"Факториал числа {N} = "+ Factorial(N,N));