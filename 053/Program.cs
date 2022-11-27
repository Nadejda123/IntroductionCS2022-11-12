// 53. Найти точку пересечения двух прямых заданных уравнением 
// y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы


void CheckPoint (double b1,double b2, double k1, double k2, out double x, out double y)
{
      x=(b1-b2)/(k2-k1);
      y = k1 * x + b1;
  }


double b1=3, b2=2,k1=5,k2=4;
if (k1==k2) System.Console.WriteLine("Линии паралельны");
else
{
double x,y;
CheckPoint (b1,b2,k1,k2, out x, out y);
System.Console.WriteLine ("Точка пересечения x: "+ $"{x}");
System.Console.WriteLine ("Точка пересечения y: "+ $"{y}");
}


