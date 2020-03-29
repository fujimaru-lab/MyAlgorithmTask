using System;

namespace Pascal
{
    class Program
    {
        private static int N = 12;

        static void Main(string[] args)
        {
            for (int n = 0; n <= N; n++)
            {
                for (int t = 0; t < (N - n) * 3; t++)
                {
                    Console.Write(" ");
                }
                for (int r = 0; r <= n; r++)
                {
                    Console.Write("{0, 3:F0}   ", Combination(n, r));
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        private static double Combination(int n, int r)
        {
            long res = 1;

            for (int i = 1; i <= r; i++)
            {
                res = res * (n - i + 1) / i;
            }
            return res;
        }
    }
}
