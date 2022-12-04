//Написать программу показывающие первые N чисел, 
//для которых каждое следующее равно сумме двух предыдущих. 
//Первые два элемента последовательности 0 и 1 

int Fibonachi(int n)
{
if (n == 0 || n == 1) return n;
return Fibonachi(n - 1) + Fibonachi(n - 2);
}

void PrintArray (int n)
{
for (int i=0;i<n;i++)
System.Console.Write($"{Fibonachi(n-i)}" +", ");
}

int n= Convert.ToInt32(Console.ReadLine());
PrintArray(n);



