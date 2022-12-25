using System;

class Program
{
    static int req_mult_3(int n)
    {
        if (n == 0) return 1;
        else if (n > 0) return 2 * req_mult_3(1-n) + 3 * req_mult_3(n - 1) + 2;
        else return -1* req_mult_3(-n);
    }
    static int ways_from_1_to_31_wout_21(int x, int y)
    {
        if (x == 21) return 0;
        if (x == y) return 1;
        else if (x > y) return 0;
        else return ways_from_1_to_31_wout_21(x + 2, y) + ways_from_1_to_31_wout_21(x * 3, y);
    }
    public static void Main()
    {
        int res = 0;
        for (int i = -15; i < 21; i++ )if (req_mult_3(i) % 3 == 0) res++;
        Console.WriteLine($"Количество результатов рекурсии, делящихся нацело на 3:{res} ");
        Console.WriteLine($"Количество программ, которые преобразуют число от 1 до 31, обходя 21: {ways_from_1_to_31_wout_21(1, 31)}");
    }
}
