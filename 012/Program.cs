//12. С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа
/*Вариант1 - сама решила
System.Console.WriteLine("Введите значение a: ");
int a=Convert.ToInt32(Console.ReadLine());
int MaxNumber = a%10;
if (a/10>MaxNumber) MaxNumber = a/10;
System.Console.WriteLine(MaxNumber);*/

// Вариант 2 решение с проверка на соответсвии условии с оператором  "do" (решение на уроке)

int n;
do
{
    System.Console.WriteLine("Введите целое число от 10 до 99: ");
    n=Convert.ToInt32(Console.ReadLine());
}
while(n<10 || n>99);
int d1=n/10;
int d2=n%10;
int max;
if (d1>d2) max=d1; else max=d2;
System.Console.WriteLine($"Максимальное число: {max}");
