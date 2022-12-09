// 89. Подсчитать сумму цифр, встречающихся в строке


string? a=Console.ReadLine();
int sum=0;
 foreach (char c in a)
 {
    if (!char.IsDigit(c))
    continue;
    int s = 0;
    if (!int.TryParse(c.ToString(), out s))
    continue;
    sum +=s;
    }
    Console.WriteLine(sum);
            
