
// 86. Подсчитать сколько раз определенный символ (например 'a') встречается в строке.


string? s=Console.ReadLine();
char find =Convert.ToChar(Console.Read());
int k=0;
foreach(char c in s)
    if (c ==find) k++;
System.Console.WriteLine(k);

