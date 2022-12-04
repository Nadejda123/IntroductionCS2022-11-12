// 75 Написать программу вычисления функции Аккермана - 5*



 ulong Akerman(ulong n, ulong m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akerman(n - 1, 1);
    else
      return Akerman(n - 1, Akerman(n, m - 1));
}

Console.Write("Введите число n: ");
ulong n = Convert.ToUInt64(Console.ReadLine());
Console.Write("Введите число m: ");
ulong m = Convert.ToUInt64(Console.ReadLine());
System.Console.WriteLine(Akerman(n,m));

