// 14. С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.

System.Console.WriteLine("Веедите значение а: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ведите зачение b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a%b==0)
{
    System.Console.WriteLine($"{a} Кратно {b}");
}
else 
{
    System.Console.WriteLine($"{a} Некратно {b}"+ $" Остаток от деления {a%b}");
}
