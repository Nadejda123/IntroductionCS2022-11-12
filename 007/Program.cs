//07. Выяснить является ли число чётным.

System.Console.WriteLine("Введите значение a: ");
int a=Convert.ToInt32(Console.ReadLine());
if (a%2==0)
{
    System.Console.WriteLine($"{a}= Четное число");
}
else
{
    System.Console.WriteLine($"{a}= Нетное число");
}

