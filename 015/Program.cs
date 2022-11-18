// 15. С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).
System.Console.WriteLine("Введите целое число");
int a =Convert.ToInt32(Console.ReadLine());
//523=3
if (a<100)
{
    System.Console.WriteLine("NO");
}
else
{
    System.Console.WriteLine(a/100%10);
}
