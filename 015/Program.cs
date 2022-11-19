// 15. С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).

/*Ватиант 1 - простой ( третия цыфра с конца)
//523=3

System.Console.WriteLine("Введите целое число");
int n =Convert.ToInt32(Console.ReadLine());
if (n<100)
{
    System.Console.WriteLine("NO");
}
else
{
    System.Console.WriteLine(a/100%10);
}
*/

// Вариант 2 - третия цифра с начала (и в случае если отрицательное число)

System.Console.WriteLine("Введите целое число");
int n =Convert.ToInt32(Console.ReadLine());
n=Math.Abs(n);
if (n>99)
{
    while (n>1000)
    {
        n=n/10;
    }
    System.Console.WriteLine(n%10);
}
else
{
    System.Console.WriteLine("NO");
}