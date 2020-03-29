using System;

namespace AlgorithmsWithCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Number:");
            var num = int.Parse(Console.ReadLine());

            for (int n = 0; n <= num; n++)
            {
                for (int r = 0; r <= n; r++)
                {
                    Console.Write("{0}C{1} = {2}  ", n, r, Combination(n, r));
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }

        private static long Combination(int n, int r)
        {
            long p = 1;
            for (int i = 1; i <= r; i++)
            {
                p = p * (n - i + 1) / i;
            }
            return p;
        }
    }
}
