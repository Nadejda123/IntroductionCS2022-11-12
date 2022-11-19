//22. Программа проверяет пятизначное число на палиндромом.

System.Console.WriteLine("Ведите пятизначное число: ");
int a =Convert.ToInt32(Console.ReadLine());
if (a>99999||a<10000) System.Console.WriteLine("Недопустимое значение");
else{
    if (a/10000==a%10) System.Console.WriteLine($"Число {a} палиндром ");
        else {System.Console.WriteLine($"Число {a} не является палиндромом ");
        }
    }
    