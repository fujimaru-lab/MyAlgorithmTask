using System;

namespace Rank
{
    class Program
    {
        private static int[] points = { 56, 25, 67, 88, 100, 61, 55, 67, 76, 56 };

        static void Main(string[] args)
        {
            foreach(var point in points)
            {
                Console.WriteLine("Point:{0, 3:D} - Rank:{1, 2:D}", point, CalcRank(points, point));
            }
            Console.ReadKey();
        }

        private static int CalcRank(int[] points, int stdPoint)
        {
            int rank = 1;
            foreach(var point in points)
            {
                if(stdPoint < point)
                {
                    rank++;
                }
            }
            return rank;
        }
    }
}
