// 71. Показать натуральные числа от N до 1, N задано



 void NatureNumbers(int n)
    {
        if (n > 0)
        {
            Console.Write("{0} ", n);
            NatureNumbers(n - 1);
        }
    }

int n = Convert.ToInt32(Console.ReadLine());
NatureNumbers(n);
