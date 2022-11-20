//29. Подсчитать сумму цифр в числе. Сделать подпрограмму.
 int CountSum(int Number)
    {
        Number = Math.Abs(Number);
        int sum = 0;
        while (Number > 0)
        {
            sum = sum + Number % 10;
            Number = Number / 10;
        }
        return sum;
    }
System.Console.WriteLine("Ввидите число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine( $"Сумма цифр числа {a} = "+CountSum(a));
