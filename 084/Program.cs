// 84. Определить являются ли введенные с клавиатуры символы правильно записью целого числа. Вычислить сумму цифр введенного числа

bool Checking (string? num)
{
int temp = 0;
if (!Int32.TryParse(num, out temp))
return false;
else return true;
}

string? num = Console.ReadLine();
if (Checking(num))
 {
    int sum = 0;
    foreach (char digit in num)
    sum += digit - 48;
    Console.WriteLine(sum);
 }
else
Console.WriteLine("Это не является верной записью целого числа");
