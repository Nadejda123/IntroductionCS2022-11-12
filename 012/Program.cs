//12. С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа

System.Console.WriteLine("Введите значение a: ");
int a=Convert.ToInt32(Console.ReadLine());
int MaxNumber = a%10;
if (a/10>MaxNumber) MaxNumber = a/10;
System.Console.WriteLine(MaxNumber);
