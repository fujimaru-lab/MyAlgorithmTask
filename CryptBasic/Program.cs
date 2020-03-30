using System;

namespace CryptBasic
{
    class Program
    {
        private static string[] table = {"Q", "W", "E", "R", "T", "Y", "U", "I", "O",
                                         "P", "A", "S", "D", "F", "G", "H", "J", "K",
                                         "L", "Z", "X", "C", "V", "B", "N", "M", "?"};
        private static char[] baseTable = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I',
                                             'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R',
                                             'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
        static void Main(string[] args)
        {
            string data = "KSOIDHEPZ";
            foreach( var chr in data)
            {
                bool isExist = false;
                int index = table.Length - 1;
                for(var i = 0; i < baseTable.Length; i++)
                {
                    isExist = chr == baseTable[i];
                    if (isExist)
                    {
                        index = i;
                        i = baseTable.Length;
                    }
                }
                Console.Write(table[index]);
            }

            Console.ReadKey();
        }

    }
}
