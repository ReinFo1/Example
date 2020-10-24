using System;

namespace Z1_isrpo
{
        class Program
        {
            static void Main(string[] args)
            {
                int M2, M11, M22, R, MAX, dat, res, i, N;
                M2 = 0;
                M11 = 0;
                M22 = 0;
                MAX = 0;
                N = Convert.ToInt32(Console.ReadLine());
                for (i = 1; i <= N; i++)
                {
                    dat = Convert.ToInt32(Console.ReadLine());
                    if ((dat % 2 == 0) && ((dat % 11) > 0) && (dat > M2))
                    {
                        M2 = dat;
                    }
                    if ((dat % 11 == 0) && (dat % 2) > 0 && (dat > M11))
                    {
                        M11 = dat;
                    }
                    if ((dat % 22) == 0 && (dat > M22))
                    {
                        if (M22 > MAX)
                        {
                            MAX = M22;
                            M22 = dat;
                        }
                        else
                        {
                            if (dat > MAX)
                            {
                                MAX = dat;
                            }
                        }
                    }
                }
                R = Convert.ToInt32(Console.ReadLine());
                if (M2 * M22 < M22 * MAX)
                {
                    res = M22 * MAX;
                }
                else
                {
                    res = M2 * M11;
                }
                Console.WriteLine($"Вычисленное контрольное значение: {res}");
                if (R == res)
                {
                    Console.WriteLine("Контроль пройден.");
                }
                else
                {
                    Console.WriteLine("Контроль не пройден.");
                }
                Console.ReadKey();
            }
        }
}
