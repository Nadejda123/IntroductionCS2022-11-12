//03. С клавиатуры вводятся два числа a и b. Найти максимальное из них.
System.Console.WriteLine("Введите число a: ");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число b: ");
int b=Convert.ToInt32(Console.ReadLine());;
if (a<b)
{;
    System.Console.WriteLine($"{b} является максимальным числом");
}

else 
{
    System.Console.WriteLine($"{a} является максимальным числом");
}
