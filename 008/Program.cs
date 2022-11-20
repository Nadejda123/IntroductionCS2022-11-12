// 08. Вывести на экран числа от -N до N
/*
System.Console.WriteLine("Введите значение N: ");
int N=Convert.ToInt32(Console.ReadLine());
int i=-N;

while (i<=N)
{
    System.Console.Write($"{i} ");
    i=i+1;
} 
*/

// Второй Вариант
System.Console.WriteLine("Введите значение N: ");
int N=Convert.ToInt32(Console.ReadLine());

for ( int i=-N;i>=N;i++)
    System.Console.Write($"{i} ");

