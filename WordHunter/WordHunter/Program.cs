using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordHunter
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\hoang.tien.2016\\source\\repos\\WordHunter\\WordHunter\\loremipsum.txt";

            string[] arr = File.ReadAllText(path).Split(" ");
            string[] arrClean = arr.Distinct().ToArray();

            for (int i = 0; i < length; i++)
            {

            }
        }
    }
}
