//Сумма цифр 
 int SumDigit(int N)
 {
     if (N==0) return 0;
  else
       return SumDigit(N/10)+N%10;
 }
 System.Console.WriteLine(SumDigit(Convert.ToInt32(Console.ReadLine())));



