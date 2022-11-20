// 20. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// Домашняя работа 
/*
System.Console.WriteLine("Введите координаты точки X: ");
double x = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки Y: ");
double y = Convert.ToDouble(Console.ReadLine());
if ((x>0) && (y>0)) System.Console.WriteLine("Первая четверть");
    else { 
        if ((x<0) && (y>0)) System.Console.WriteLine("Вторая четверть");
        else{
            if ((x<0) && (y<0)) System.Console.WriteLine("Третия четверть");
            else {
                if ((x<0) && (y<0)) System.Console.WriteLine("Третия четверть");
                else {
                    if((x>0) && (y<0)) System.Console.WriteLine("Четвертая четверть"); 
                    else System.Console.WriteLine("Введены нулевые координаты");
                     }
                 }
            }

        }
*/
//Вариант решения задачи с добавлением 3 переменной 
/*        
System.Console.WriteLine("Введите координаты точки X: ");
double x = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки Y: ");
double y = Convert.ToDouble(Console.ReadLine());
int part =0;
if(x>0&& y>0) part=1;
if(x<0 && y>0) part =2;
if (x<0 && y<0) part =3;
if (x>0 && y<0) part =4;
System.Console.WriteLine("Part:"+part);
*/
// Вариант решения с под пограмами 
// тип имя ( аргументы)

int Part(double x, double y)
{
    //Тело подпрограмы;

if(x>0&& y>0) return 1;
if(x<0 && y>0) return 2;
if(x<0 && y<0) return 3;
if(x>0 && y<0) return 4;
return 0;
}

System.Console.WriteLine("Введите координаты точки X: ");
double x = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки Y: ");
double y = Convert.ToDouble(Console.ReadLine());
Part (x,y);
System.Console.WriteLine(Part(x,y));
