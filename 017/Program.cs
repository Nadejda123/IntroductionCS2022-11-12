// 17. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
int a;
do
{
    System.Console.WriteLine("Введите число обозначающее день недели : ");
    a=Convert.ToInt32(Console.ReadLine());
}
while(a<=0 || a>7);

String b;
if (a>0 & a<=5) b="Рабочий день";
else b="Выходной";
System.Console.WriteLine(b);
