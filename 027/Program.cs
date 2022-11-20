// 27 Возведите число А в натуральную степень B используя цикл


int Power (int Number, int power)
{
  Number=(int)Math.Pow(Number,power);
    return Number;
}

System.Console.WriteLine("Введите число A ");
int a=Convert.ToInt32(Console.ReadLine());
 System.Console.WriteLine("Ввелдите значение степени ");
int b=Convert.ToInt32(Console.ReadLine());   

System.Console.WriteLine($"{a} в {b} степени = " + Power(a,b));

