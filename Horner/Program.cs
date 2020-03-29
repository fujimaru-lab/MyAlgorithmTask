using System;

namespace Horner
{
    class Program
    {
        private static int[] a = { 1, 2, 3, 4, 5/*, 6, 7*/ };

        static void Main(string[] args)
        {
            string fmt = "fn({0, 0:F3}) = {1, 10:F5}";

            try
            {
                for (double x = 0.1; x <= 3; x += 0.1)
                {
                    Console.WriteLine(fmt, x, funcN(x, a.Length));
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("演算回数が、係数配列のサイズを超えました。\n処理を終了します。");
            }
            finally
            {
                Console.ReadKey();

            }
        }

        /// <summary>
        /// Hornerの方法の実装
        /// </summary>
        /// <param name="x"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        private static double funcN(double x, int n)
        {
            if (n > a.Length)
            {
                throw new ArgumentOutOfRangeException();
            }

            double res = 0;
            double @base = 1;

            for (int i = 0; i < n; i++)
            {
                @base *= i == 0 ? 1 : x;
                res += @base * a[i];
            }

            return res;
        }
    }
}
