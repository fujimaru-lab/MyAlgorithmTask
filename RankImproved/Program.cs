using System;

namespace RankImproved
{
    class Program
    {
        private static int[] data = { 12, 3, 45, 32, 31, 50, 88, 81, 88, 32, 66, 100, 91, 91, 91, 45, 43, 72, 72, 0, 0, 100, 32, 1};

        static void Main(string[] args)
        {
            int[] ranks = new int[101]; // 0から100の値域

            for (int i = 0; i < ranks.Length; i++)
            {
                ranks[i] = 0;
            }
            ranks[ranks.Length - 1] = 1;

            foreach (var d in data)
            {
                ranks[d]++;
            }

            // ranks配列の末尾から各数字の個数を数えて足していき順位を計算する
            int rank = 1;
            for (int i = ranks.Length - 1; i >= 0; i--)
            {
                if(ranks[i] != 0)
                {
                    var tmp = ranks[i];
                    ranks[i] = rank;
                    rank += tmp;
                }
            }

            foreach (var d in data)
            {
                Console.WriteLine("Point:{0, 3:D} - Rank:{1, 3:D}", d, ranks[d]);
            }

            Console.ReadKey();
        }
    }
}
