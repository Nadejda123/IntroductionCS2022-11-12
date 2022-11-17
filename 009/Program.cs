// 09. Вывести на экран четные числа от 1 до N
System.Console.WriteLine("Введите значение N: ");
int N=Convert.ToInt32(Console.ReadLine());
int i=2;
// Пырвый вариант решения через оператор "While"
while (i<=N)
{
    System.Console.Write($"{i} ");
    i=i+2;
}
// Второй вариант решения через оператор "for"
System.Console.WriteLine();
for (int j=2;j<=N;j=j+2)
{
    System.Console.Write($"{j} ");

}
// Решение задачи четных чисел через вычесление остатка после деления 
System.Console.WriteLine();
for( int j=1; j<=N; j++)
{
    if (j%2==0)
    {
        System.Console.Write($"{j} ");
    }
}