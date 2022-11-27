// С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры
  // заполнение массива
  
int[] DataInput(int[] a, int N)
{
    a = new int[N];
    for (int i = 0; i < a.Length; i++)
    a[i] = Convert.ToInt32(Console.ReadLine());
    return a;
}
//печать массива
void PrintArray(int[] a, int tab = 5)
{
    string FormatString = "{0," + tab + "}";
    for (int i = 0; i < a.Length; i++)
    Console.Write(FormatString, a[i]);
}

// обработка массива
int Result(int[] a)
{
  int count = 0;
    for (int i = 0; i < a.Length; i++)
    if (a[i] > 0)
    count++;
    return count;
}

Console.WriteLine("Введите число  ");
int N = Convert.ToInt32(Console.ReadLine());
int[] a = new int[N];
a = DataInput(a, N);
Console.WriteLine();
PrintArray(a);
Console.WriteLine();
Console.WriteLine($"чисел >0 введено = " + $"{Result(a)}");