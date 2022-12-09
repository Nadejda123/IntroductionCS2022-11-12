// 82. C клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки


string? s=Console.ReadLine();
int k=0;
foreach(char c in s)
    if (c !='.') k++;
System.Console.WriteLine(k);

