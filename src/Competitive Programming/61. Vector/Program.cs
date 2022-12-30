///https://onlinejudge.u-aizu.ac.jp/problems/ITP2_1_A

using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {

        int q = Convert.ToInt32(Console.ReadLine());
        List<int> list = new List<int>();
        while (q-- > 0)
        {
            int[] line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int len = line.Length;

            if (line[0] == 0)
            {
                list.Add(line[1]);
            }
            else if (line[0] == 1)
            {
                Console.WriteLine(list[line[1]]);
            }
            else
            {
                list.RemoveAt(list.Count - 1);
            }
        }

    }
}
