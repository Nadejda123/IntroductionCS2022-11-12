﻿ /*Напишите  программу,  которая  в  последовательности  натуральных  чисел 
определяет минимальное число, оканчивающееся на 4. Программа получает 
на  вход  количество  чисел  в  последовательности,  а  затем  сами  числа.  
В последовательности всегда имеется число, оканчивающееся на 4. 
Количество  чисел  не  превышает 1000. Введённые  числа  не  превышают  
30 000. 
Программа должна вывести одно число – минимальное число, оканчивающееся 
на 4.
*/

int n=Convert.ToInt32(Console.ReadLine());
int min = 30000;
for ( int i=0;i<n; i++)
{
    int a= Convert.ToInt32(Console.ReadLine()); //ВВодим числа 
    if (a<min && a%10==4) min=a;
}
System.Console.WriteLine(min);