// 11. Дано число больше 9. Вывести на экран  вторую цифру числа с конца

System.Console.WriteLine("Введите значение a: ");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(a/10%10);
