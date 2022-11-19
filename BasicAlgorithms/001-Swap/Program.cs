// Обмен значениями двух переменых
// Классическтй способ 
/*
int a=5;
int b=7;
int temp;
temp=a;
a=b;
b=temp;
*/

//Метод без использования 3-ей переменой
/*
int a=5;
int b=7;
a=a+b;
b=a-b;
a=a-b;
*/
// Третий Вариант 
 int a=5;
 int b=7;
 a=a^b;
 b=a^b;
 a=a^b;
 System.Console.WriteLine($"a ={a} b={b}");
 




