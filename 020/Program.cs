// 20. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

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