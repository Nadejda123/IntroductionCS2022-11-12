﻿// 23.  Найти расстояние между точками в пространстве 2D

double x1,x2,y1,y2,distance;
x1=Convert.ToDouble(Console.ReadLine());
x2=Convert.ToDouble(Console.ReadLine());
y1=Convert.ToDouble(Console.ReadLine());
y2=Convert.ToDouble(Console.ReadLine());

distance=Math.Sqrt(x2-x1)*(x2-x1) + Math.Pow(y2-y1,2); 
// два варианта записи уровнения (Math.Pow(y2-y1,2) двойка означает что в квадрате )
System.Console.WriteLine(distance);