using System;

namespace Histogram
{
    class Program
    {

        private static int[] datas = { 23, 35, 89, 66, 44, 11, 3, 100, 99, 55, 87, 77, 12, 11, 10, 9, 0, 100, 55, 67, 51, 48, 38 };

        static void Main(string[] args)
        {
            var histo = MapData(datas);

            for(int i = 0; i < histo.Length; i++)
            {
                Console.WriteLine("{0, 3:D} - {1, 3:D}", i, histo[i]);
            }
            Console.ReadKey();
        }

        private static int[] MapData(int[] datas)
        {
            int[] histo = new int[11];

            foreach(var data in datas)
            {
                var rank = data / 10;
                histo[rank]++;
            }
            return histo;
        }
    }
}
